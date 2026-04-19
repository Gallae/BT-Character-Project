using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class findTargetAT : ActionTask {

		public BBParameter<GameObject> target;
		public BBParameter<int> blueSeeds;
		public BBParameter<int> redSeeds;
        public BBParameter<int> yellowSeeds;
        public bool findSeed;


        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			if (findSeed)
			{
				target.value = GameObject.FindGameObjectWithTag("Seed");
			}
			else
			{
				ChooseBin();
            }
                EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}

		void ChooseBin()
		{
			if (blueSeeds.value > redSeeds.value && blueSeeds.value > yellowSeeds.value)
			{
				target.value = GameObject.FindGameObjectWithTag("BlueBin");
			}
			else if (redSeeds.value > blueSeeds.value && redSeeds.value > yellowSeeds.value)
			{
				target.value = GameObject.FindGameObjectWithTag("RedBin");
			}
			else if (yellowSeeds.value > blueSeeds.value && yellowSeeds.value > redSeeds.value)
			{
				target.value = GameObject.FindGameObjectWithTag("YellowBin");
			}
        }
    }
}