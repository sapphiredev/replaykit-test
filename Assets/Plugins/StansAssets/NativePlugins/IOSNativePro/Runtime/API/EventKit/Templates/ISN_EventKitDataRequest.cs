using SA.Foundation.Time;
using UnityEngine;
using System;

namespace SA.iOS.EventKit
{
    /// <summary>
    /// This is data that we need to send to EventKit for saving event or reminder.
    /// </summary>
    [Serializable]
    public class ISN_EventKitDataRequest
    {
        
#pragma warning disable 414
        [SerializeField] string m_Title = null;
        [SerializeField] long m_StartDate = -1;
        [SerializeField] long m_EndDate = -1;
#pragma warning restore 414
        
        /// <summary>
        /// Create ISN_EventKitDataRequest object.
        /// </summary>
        /// <param name="title">Title of event or reminder</param>
        public ISN_EventKitDataRequest(string title)
        {
            m_Title = title;
        }

        /// <summary>
        /// Create ISN_EventKitDataRequest object.
        /// </summary>
        /// <param name="title">Title of event or reminder</param>
        /// <param name="startDate"> Start date of event or reminder</param>
        /// <param name="endDate"> End date of event or reminder</param>
        public ISN_EventKitDataRequest(string title, DateTime startDate, DateTime endDate)
        {
            m_Title = title;
            m_StartDate = SA_Unix_Time.ToUnixTime(startDate);
            m_EndDate = SA_Unix_Time.ToUnixTime(endDate);
        }
    }
}
