using System;

namespace Hooks
{
	[RuntimeHookAttribute]
	public class ImplLaunchOption
	{
		public ImplLaunchOption()
		{
			HookRegistry.Register (OnCall);
		}

		object OnCall(string typeName, string methodName, object this_obj, params object[] args) {
			if (typeName != "BattleNet" || methodName != "GetLaunchOption") {
				return null;
			}
			return "enUS";
		}
	}
}

