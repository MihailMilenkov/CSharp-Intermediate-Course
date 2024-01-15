// See https://aka.ms/new-console-template for more information
using CSharpIntermediateCourse;
using CSharpIntermediateCourse.Workflow;

//StopWatch stopWatch = new StopWatch(); // 1
//stopWatch.TurnOn();

//StackOverflowPost post = new StackOverflowPost(); // 2
//post.TurnOn();

//StackStack stack = new StackStack(); // 3
//.TurnOn();

Workflow wf = new Workflow(); // 4
WorkFlowObjA wfObjA = new WorkFlowObjA();
WorkFlowObjB wfObjB = new WorkFlowObjB();
wf.Run(wfObjA);
wf.Run(wfObjB);