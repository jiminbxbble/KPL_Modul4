using System;

public class MesinKopi
{
	public enum State
	{
		OFF,
		STANDBY,
		BREWING,
		MAINTENANCE
	}

	public enum Trigger
	{
		POWER_ON,
		START_BREW,
		FINISH_BREW,
		START_MAINTENANCE,
		FINISH_MAINTENANCE,
		POWER_OFF
	}

	public State currentState = State.OFF;

	public void TriggerState(Trigger trigger)
	{
		State nextState = currentState;
		string message = "";
		switch (currentState)
		{
			case State.OFF:
				if(trigger == Trigger.POWER_ON)
				{
					nextState = State.STANDBY;
					message = "Mesin Off berubah menjadi Standby";
				}
				break;
			case State.STANDBY:
				if(trigger == Trigger.START_BREW)
				{
					nextState = State.BREWING;
					message = "Mesin Standby berubah menjadi Brewing";
				}
				else if(trigger == Trigger.START_MAINTENANCE)
				{
					nextState = State.MAINTENANCE;
					message = "Mesin Standby berubah menjadi Maintenance";
				}
				else if (trigger == Trigger.POWER_OFF)
				{
					nextState = State.OFF;
					message = "Mesin Standby berubah menjadi Off";
				}
				break;
			case State.BREWING:
				if(trigger == Trigger.FINISH_BREW)
				{
					nextState = State.STANDBY;
					message = "Mesin Brewing berubah menjadi Standby";
				}
				break;
			case State.MAINTENANCE:
				if(trigger == Trigger.FINISH_MAINTENANCE)
				{
					nextState = State.STANDBY;
					message = "Mesin Maintenance berubah menjadi Standby";
				}
				break;
		}
		if (nextState != currentState) {
			Console.WriteLine(message);
			currentState = nextState;
		}
		else { 
			Console.WriteLine("Perubahan state tidak valid"); 
		}
	}
}
