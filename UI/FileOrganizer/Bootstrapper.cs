using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef;

namespace FileOrganizer
{
    public class Bootstrapper: MefBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            //return Container.GetExportedValue<System.Windows.Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            //AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
        }
    }
}
