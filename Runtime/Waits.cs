using System.Collections.Generic;
using UnityEngine;

namespace MasterDisaster64.Waits
{
    public static class Waits
    {
        public static readonly WaitForFixedUpdate fixedUpdate = new();
        public static readonly WaitForEndOfFrame endOfFrame = new();

        private static Dictionary<float, WaitForSeconds> secondsDict = new();
        private static Dictionary<float, WaitForSecondsRealtime> secondsRealtimeDict = new();

        public static WaitForSeconds Seconds(float time)
        {
            try
            {
                return secondsDict[time];
            }
            catch (KeyNotFoundException)
            {
                var newWait = new WaitForSeconds(time);
                secondsDict[time] = newWait;
                return newWait;
            }
        }

        public static WaitForSecondsRealtime SecondsRealtime(float time)
        {
            try
            {
                return secondsRealtimeDict[time];
            }
            catch (KeyNotFoundException)
            {
                var newWait = new WaitForSecondsRealtime(time);
                secondsRealtimeDict[time] = newWait;
                return newWait;
            }
        }
    }
}
