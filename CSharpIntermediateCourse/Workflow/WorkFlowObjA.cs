namespace CSharpIntermediateCourse.Workflow
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class WorkFlowObjA : IWorkFlowObj
    {
        public void Execute()
        {
            Console.WriteLine("I am WFO A");
        }
    }
}
