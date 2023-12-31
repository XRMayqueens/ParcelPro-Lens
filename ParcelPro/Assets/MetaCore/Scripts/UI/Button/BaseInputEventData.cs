﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using UnityEngine.EventSystems;
using Pnc.Model.Hands;

namespace Pnc.UI.Button
{
    /// <summary>
    /// Base class of all input events.
    /// </summary>
    public abstract class BaseInputEventData : BaseEventData
    {
        /// <summary>
        /// The UTC time at which the event occurred.
        /// </summary>
        public DateTime EventTime { get; private set; }

        /// <summary>
        /// The source the input event originates from.
        /// </summary>
        public HandsResult handsResult { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="eventSystem">Typically will be <see href="https://docs.unity3d.com/ScriptReference/EventSystems.EventSystem-current.html">EventSystems.EventSystem.current</see></param>
        protected BaseInputEventData(EventSystem eventSystem) : base(eventSystem) { }

        /// <summary>
        /// Used to initialize/reset the event and populate the data.
        /// </summary>
        protected void BaseInitialize(HandsResult handedness)
        {
            Reset();
            EventTime = DateTime.UtcNow;
            handsResult = handedness;
        }
    }
}
