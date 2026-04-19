using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class allSeedDepositedCT : ConditionTask {

		public BBParameter<int> blueSeeds;
		public BBParameter<int> redSeeds;
		public BBParameter<int> yellowSeeds;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			return blueSeeds.value == 0 && redSeeds.value == 0 && yellowSeeds.value == 0;
		}
	}
}