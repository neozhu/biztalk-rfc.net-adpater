using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BizTalk.Adapter.RFC.Core
{
    public class SchemaCacheManager
    {
        private static ReaderWriterLock rwl;

        private static Dictionary<string, XmlSchema> schemaCache;
        static SchemaCacheManager()
        {
            rwl = new ReaderWriterLock();
            schemaCache = new Dictionary<string, XmlSchema>();
        }
        public static void Add(string key, XmlSchema schema)
        {
            rwl.AcquireWriterLock(-1);
            try
            {
                if (!schemaCache.ContainsKey(key))
                    schemaCache.Add(key, schema);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }

        }
        public static bool ContainsKey(string key)
        {
            bool isContain = false;
            rwl.AcquireReaderLock(-1);
            isContain = schemaCache.ContainsKey(key);
            rwl.ReleaseReaderLock();
            return isContain;
        }
        public static XmlSchema GetByKey(string key)
        {
            XmlSchema schema = null;
            rwl.AcquireReaderLock(-1);
            schema = schemaCache[key];
            rwl.ReleaseReaderLock();
            return schema;
        }
    }

    public class AssemblySelector
    {
        public AssemblySelector()
        {

        }

        public AssemblySelector(string assemblyName,string assemblyTypeName)
        {
            this.AssemblyTypeName = assemblyTypeName;
            if (assemblyName.IndexOf(":\\") >= 0)
            {
                _assembly = Assembly.LoadFile(assemblyName);
            }
            else {
                _assembly = Assembly.Load(assemblyName);
            }
          
            
        }

        public AssemblySelector(string assemblyQualifiedName) {
            _assemblyQualifiedName = assemblyQualifiedName;
        }

        public string AssemblyTypeName { get; set; }

        public string AssemblyQualifiedName
        {
            get
            {
                return _assemblyQualifiedName;
            }

         
        }

        private string _assemblyQualifiedName;
        private Assembly _assembly;
        private string GetAssemblyTypeName()
        {
           
            return this.AssemblyTypeName;
        }

        public XmlSchema GetSchema()
        {
            if (!string.IsNullOrEmpty(this._assemblyQualifiedName))
            {
                return this.GetSchemaByQualifiedName();
            }
            else
            {
                return this.GetSchemaByAssembly();
            }
            


        }
        private XmlSchema GetSchemaByAssembly()
        {
            string typeName = this.GetAssemblyTypeName();
            if (SchemaCacheManager.ContainsKey(typeName))
            {
                return SchemaCacheManager.GetByKey(typeName);
            }
            object obj = this._assembly.CreateInstance(typeName);
            if (obj == null)
                throw new NullReferenceException(//Err0003
                    string.Format("Not found schema type {0} with in  assembly {0},Please rebuilding and redeploying.", typeName)
                    );

            Microsoft.XLANGs.BaseTypes.SchemaBase bSchema =
                (Microsoft.XLANGs.BaseTypes.SchemaBase)obj;
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(bSchema.Schema);
            schemaSet.Compile();
            SchemaCacheManager.Add(typeName, bSchema.Schema);
            return bSchema.Schema;

        }

        private XmlSchema GetSchemaByQualifiedName() {
            
            Type schemaType = Type.GetType(this._assemblyQualifiedName);
            this._assemblyQualifiedName = schemaType.AssemblyQualifiedName;


            if (SchemaCacheManager.ContainsKey(_assemblyQualifiedName))
            {
                return SchemaCacheManager.GetByKey(_assemblyQualifiedName);
            }
            var obj = Activator.CreateInstance(schemaType);
            
            if (obj == null)
                throw new NullReferenceException(//Err0003
                    string.Format("Not found schema type {0} with in assembly,Please rebuilding and redeploying. ", _assemblyQualifiedName)
                    );

            Microsoft.XLANGs.BaseTypes.SchemaBase bSchema =
                (Microsoft.XLANGs.BaseTypes.SchemaBase)obj;
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(bSchema.Schema);
            schemaSet.Compile();
            SchemaCacheManager.Add(_assemblyQualifiedName, bSchema.Schema);
            return bSchema.Schema;
        }




    }
}
