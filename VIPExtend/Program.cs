using DataRepository;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIPExtend
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Boolean createdNew;
            Mutex instance = new Mutex(true, "VIPExtend", out createdNew);
            if (createdNew)
            {
                Task.Factory.StartNew(() =>
                {
                    using (var dbcontext = new Model1())
                    {
                        var objectContext = ((IObjectContextAdapter)dbcontext).ObjectContext;
                        var mappingCollection = (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
                        mappingCollection.GenerateViews(new List<EdmSchemaError>());
                    }
                });
                ApplicationInstance.Instance.Init();
                //对程序中定义的所有DbContext逐一进行这个操作
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                instance.ReleaseMutex();
            }
            else
            {
                Application.Exit();
            }
        }


    }
}
