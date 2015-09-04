using System;
using PushNotification.Plugin;
using System.Collections.Generic;
using PushNotification.Plugin.Abstractions;
using System.Diagnostics;

namespace XFormsPushNotifications
{
	public class CrossPushNotificationListener : IPushNotificationListener
	{
		public void OnMessage (IDictionary<string, object> Parameters, DeviceType deviceType)
		{

		}

		public void OnRegistered (string Token, DeviceType deviceType)
		{

		}

		public void OnUnregistered (DeviceType deviceType)
		{

		}

		public void OnError (string message, DeviceType deviceType)
		{

		}

		// Fires when error.
		void IPushNotificationListener.OnError(string message, DeviceType deviceType)
		{
			Debug.WriteLine(string.Format("Push notification error - {0}", message));
		}

		// Enable/Disable showing the notification.
		bool IPushNotificationListener.ShouldShowNotification()
		{
			return true;
		}
	}
}
