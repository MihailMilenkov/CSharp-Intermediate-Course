namespace CSharpIntermediateCourse.Workflow
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Workflow : IWorkFlow
    {
        public void Run(IWorkFlowObj obj)
        {
            obj.Execute();
        }
    }
}
