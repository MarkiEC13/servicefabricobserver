﻿#region Copyright

// //=======================================================================================
// // Microsoft Azure Customer Advisory Team  
// //
// // This sample is supplemental to the technical guidance published on the community
// // blog at http://blogs.msdn.com/b/paolos/. 
// // 
// // Author: Paolo Salvatori
// //=======================================================================================
// // Copyright © 2016 Microsoft Corporation. All rights reserved.
// // 
// // THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
// // EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
// // MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE. YOU BEAR THE RISK OF USING IT.
// //=======================================================================================

#endregion

namespace Microsoft.AzureCat.Samples.ObserverPattern.TestObservableObserverActor.Interfaces
{
    #region Using Directives

    using System.Threading.Tasks;
    using Microsoft.ServiceFabric.Actors;

    #endregion

    /// <summary>
    ///     This interface represents the actions a client app can perform on an actor.
    ///     It MUST derive from IActor and all methods MUST return a Task.
    /// </summary>
    public interface ITestObservableObserverActor : IActor
    {
        Task ExecuteCommandAsync(string command);
    }
}