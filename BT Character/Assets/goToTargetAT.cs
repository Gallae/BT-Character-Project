using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Numerics;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class goToTargetAT : ActionTask {

		public BBParameter<GameObject> target;
		public float arrivalDistance;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			float distanceToTarget = UnityEngine.Vector3.Distance(agent.transform.position, target.value.transform.position);
            if (distanceToTarget >= arrivalDistance)
			{
                UnityEngine.Vector3 moveDirection = (target.value.transform.position - agent.transform.position).normalized;
                agent.transform.position += moveDirection * Time.deltaTime * 5f;
            }
            else
			{
				EndAction(true);
            }
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}