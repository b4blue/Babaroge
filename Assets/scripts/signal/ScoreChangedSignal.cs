/// Signal fired when the score changes
/// 
/// string The new score (already formatted)

using System;
using strange.extensions.signal.impl;

namespace signals
{
	public class ScoreChangedSignal : Signal<string>
	{
	}
}

