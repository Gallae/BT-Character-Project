using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class dropSeedAT : ActionTask {

		public BBParameter<GameObject> targetBin;
		public BBParameter<int> blueSeeds;
		public BBParameter<int> redSeeds;
        public BBParameter<int> yellowSeeds;
        public BBParameter<GameObject> blueTracker;
        public BBParameter<GameObject> redTracker;
        public BBParameter<GameObject> yellowTracker;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			if (targetBin.value.tag == "BlueBin")
			{
				blueSeeds.value = 0;
                blueTracker.value.GetComponent<TextMeshProUGUI>().text = "Blue seeds: 0";
            }
			else if (targetBin.value.tag == "RedBin")
			{
				redSeeds.value = 0;
                redTracker.value.GetComponent<TextMeshProUGUI>().text = "Red seeds: 0";
            }
			else if (targetBin.value.tag == "YellowBin")
			{
				yellowSeeds.value = 0;
                yellowTracker.value.GetComponent<TextMeshProUGUI>().text = "Yellow seeds: 0";
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
	}
}