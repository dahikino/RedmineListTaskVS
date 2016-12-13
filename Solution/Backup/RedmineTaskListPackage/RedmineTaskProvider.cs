using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace RedmineTaskListPackage
{
    [Guid("c69a7a86-945e-4884-85d6-eebae9247598")]
    public class RedmineTaskProvider : TaskProvider
    {
        public RedmineTaskProvider(IServiceProvider provider)
            : base(provider)
        {
            ProviderName = "Redmine";
            AlwaysVisible = true;
            DisableAutoRoute = true;
            ToolbarGroup = Guids.guidRedmineCmdSet;
            ToolbarId = 0x1040;
        }

        public void Register()
        {
            var taskList = VsTaskList; // Get accessor invokes RegisterTaskProvider
        }

        public override void Show()
        {
            var providerGuid = typeof(RedmineTaskProvider).GUID;
            var taskList = VsTaskList as IVsTaskList2;
            
            if (taskList != null)
            {
                taskList.SetActiveProvider(ref providerGuid);
            }

            base.Show();
        }
    }
}
