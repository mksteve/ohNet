using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using Zapp.Core;

namespace Zapp.Device.Providers
{
    public interface IDvProviderLinnCoUkDelay1 : IDisposable
    {

        /// <summary>
        /// Set the value of the PresetXml property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyPresetXml(string aValue);

        /// <summary>
        /// Get a copy of the value of the PresetXml property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        string PropertyPresetXml();

        /// <summary>
        /// Set the value of the PresetIndex property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyPresetIndex(uint aValue);

        /// <summary>
        /// Get a copy of the value of the PresetIndex property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        uint PropertyPresetIndex();
        
    }
    /// <summary>
    /// Provider for the linn.co.uk:Delay:1 UPnP service
    /// </summary>
    public class DvProviderLinnCoUkDelay1 : DvProvider, IDisposable, IDvProviderLinnCoUkDelay1
    {
        private GCHandle iGch;
        private ActionDelegate iDelegatePresetXml;
        private ActionDelegate iDelegatePresetIndex;
        private ActionDelegate iDelegateSetPresetIndex;
        private ActionDelegate iDelegateSetPresetDelay;
        private ActionDelegate iDelegateSetPresetVisible;
        private ActionDelegate iDelegateSetPresetName;
        private ActionDelegate iDelegateDelayMinimum;
        private ActionDelegate iDelegateDelayMaximum;
        private ActionDelegate iDelegatePresetCount;
        private PropertyString iPropertyPresetXml;
        private PropertyUint iPropertyPresetIndex;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aDevice">Device which owns this provider</param>
        protected DvProviderLinnCoUkDelay1(DvDevice aDevice)
            : base(aDevice, "linn-co-uk", "Delay", 1)
        {
            iGch = GCHandle.Alloc(this);
            List<String> allowedValues = new List<String>();
            iPropertyPresetXml = new PropertyString(new ParameterString("PresetXml", allowedValues));
            AddProperty(iPropertyPresetXml);
            iPropertyPresetIndex = new PropertyUint(new ParameterUint("PresetIndex"));
            AddProperty(iPropertyPresetIndex);
        }

        /// <summary>
        /// Set the value of the PresetXml property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyPresetXml(string aValue)
        {
            return SetPropertyString(iPropertyPresetXml, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the PresetXml property
        /// </summary>
        /// <returns>The value of the property</returns>
        public string PropertyPresetXml()
        {
            return iPropertyPresetXml.Value();
        }

        /// <summary>
        /// Set the value of the PresetIndex property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyPresetIndex(uint aValue)
        {
            return SetPropertyUint(iPropertyPresetIndex, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the PresetIndex property
        /// </summary>
        /// <returns>The value of the property</returns>
        public uint PropertyPresetIndex()
        {
            return iPropertyPresetIndex.Value();
        }

        /// <summary>
        /// Signal that the action PresetXml is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// PresetXml must be overridden if this is called.</remarks>
        protected void EnableActionPresetXml()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("PresetXml");
            action.AddOutputParameter(new ParameterRelated("aPresetXml", iPropertyPresetXml));
            iDelegatePresetXml = new ActionDelegate(DoPresetXml);
            EnableAction(action, iDelegatePresetXml, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action PresetIndex is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// PresetIndex must be overridden if this is called.</remarks>
        protected void EnableActionPresetIndex()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("PresetIndex");
            action.AddOutputParameter(new ParameterRelated("aIndex", iPropertyPresetIndex));
            iDelegatePresetIndex = new ActionDelegate(DoPresetIndex);
            EnableAction(action, iDelegatePresetIndex, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action SetPresetIndex is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// SetPresetIndex must be overridden if this is called.</remarks>
        protected void EnableActionSetPresetIndex()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("SetPresetIndex");
            action.AddInputParameter(new ParameterRelated("aIndex", iPropertyPresetIndex));
            iDelegateSetPresetIndex = new ActionDelegate(DoSetPresetIndex);
            EnableAction(action, iDelegateSetPresetIndex, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action SetPresetDelay is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// SetPresetDelay must be overridden if this is called.</remarks>
        protected void EnableActionSetPresetDelay()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("SetPresetDelay");
            action.AddInputParameter(new ParameterUint("aIndex"));
            action.AddInputParameter(new ParameterUint("aDelay"));
            iDelegateSetPresetDelay = new ActionDelegate(DoSetPresetDelay);
            EnableAction(action, iDelegateSetPresetDelay, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action SetPresetVisible is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// SetPresetVisible must be overridden if this is called.</remarks>
        protected void EnableActionSetPresetVisible()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("SetPresetVisible");
            action.AddInputParameter(new ParameterUint("aIndex"));
            action.AddInputParameter(new ParameterBool("aVisible"));
            iDelegateSetPresetVisible = new ActionDelegate(DoSetPresetVisible);
            EnableAction(action, iDelegateSetPresetVisible, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action SetPresetName is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// SetPresetName must be overridden if this is called.</remarks>
        protected void EnableActionSetPresetName()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("SetPresetName");
            List<String> allowedValues = new List<String>();
            action.AddInputParameter(new ParameterUint("aIndex"));
            action.AddInputParameter(new ParameterString("aName", allowedValues));
            iDelegateSetPresetName = new ActionDelegate(DoSetPresetName);
            EnableAction(action, iDelegateSetPresetName, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action DelayMinimum is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DelayMinimum must be overridden if this is called.</remarks>
        protected void EnableActionDelayMinimum()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("DelayMinimum");
            action.AddOutputParameter(new ParameterUint("aDelay"));
            iDelegateDelayMinimum = new ActionDelegate(DoDelayMinimum);
            EnableAction(action, iDelegateDelayMinimum, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action DelayMaximum is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DelayMaximum must be overridden if this is called.</remarks>
        protected void EnableActionDelayMaximum()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("DelayMaximum");
            action.AddOutputParameter(new ParameterUint("aDelay"));
            iDelegateDelayMaximum = new ActionDelegate(DoDelayMaximum);
            EnableAction(action, iDelegateDelayMaximum, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action PresetCount is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// PresetCount must be overridden if this is called.</remarks>
        protected void EnableActionPresetCount()
        {
            Zapp.Core.Action action = new Zapp.Core.Action("PresetCount");
            action.AddOutputParameter(new ParameterUint("aCount"));
            iDelegatePresetCount = new ActionDelegate(DoPresetCount);
            EnableAction(action, iDelegatePresetCount, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// PresetXml action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// PresetXml action for the owning device.
        ///
        /// Must be implemented iff EnableActionPresetXml was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaPresetXml"></param>
        protected virtual void PresetXml(uint aVersion, out string aaPresetXml)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// PresetIndex action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// PresetIndex action for the owning device.
        ///
        /// Must be implemented iff EnableActionPresetIndex was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaIndex"></param>
        protected virtual void PresetIndex(uint aVersion, out uint aaIndex)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// SetPresetIndex action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// SetPresetIndex action for the owning device.
        ///
        /// Must be implemented iff EnableActionSetPresetIndex was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaIndex"></param>
        protected virtual void SetPresetIndex(uint aVersion, uint aaIndex)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// SetPresetDelay action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// SetPresetDelay action for the owning device.
        ///
        /// Must be implemented iff EnableActionSetPresetDelay was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaIndex"></param>
        /// <param name="aaDelay"></param>
        protected virtual void SetPresetDelay(uint aVersion, uint aaIndex, uint aaDelay)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// SetPresetVisible action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// SetPresetVisible action for the owning device.
        ///
        /// Must be implemented iff EnableActionSetPresetVisible was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaIndex"></param>
        /// <param name="aaVisible"></param>
        protected virtual void SetPresetVisible(uint aVersion, uint aaIndex, bool aaVisible)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// SetPresetName action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// SetPresetName action for the owning device.
        ///
        /// Must be implemented iff EnableActionSetPresetName was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaIndex"></param>
        /// <param name="aaName"></param>
        protected virtual void SetPresetName(uint aVersion, uint aaIndex, string aaName)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// DelayMinimum action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// DelayMinimum action for the owning device.
        ///
        /// Must be implemented iff EnableActionDelayMinimum was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaDelay"></param>
        protected virtual void DelayMinimum(uint aVersion, out uint aaDelay)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// DelayMaximum action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// DelayMaximum action for the owning device.
        ///
        /// Must be implemented iff EnableActionDelayMaximum was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaDelay"></param>
        protected virtual void DelayMaximum(uint aVersion, out uint aaDelay)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// PresetCount action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// PresetCount action for the owning device.
        ///
        /// Must be implemented iff EnableActionPresetCount was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aaCount"></param>
        protected virtual void PresetCount(uint aVersion, out uint aaCount)
        {
            throw (new ActionDisabledError());
        }

        private static int DoPresetXml(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            string aPresetXml;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.PresetXml(aVersion, out aPresetXml);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteString("aPresetXml", aPresetXml);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoPresetIndex(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aIndex;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.PresetIndex(aVersion, out aIndex);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteUint("aIndex", aIndex);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoSetPresetIndex(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aIndex;
            try
            {
                invocation.ReadStart();
                aIndex = invocation.ReadUint("aIndex");
                invocation.ReadEnd();
                self.SetPresetIndex(aVersion, aIndex);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoSetPresetDelay(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aIndex;
            uint aDelay;
            try
            {
                invocation.ReadStart();
                aIndex = invocation.ReadUint("aIndex");
                aDelay = invocation.ReadUint("aDelay");
                invocation.ReadEnd();
                self.SetPresetDelay(aVersion, aIndex, aDelay);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoSetPresetVisible(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aIndex;
            bool aVisible;
            try
            {
                invocation.ReadStart();
                aIndex = invocation.ReadUint("aIndex");
                aVisible = invocation.ReadBool("aVisible");
                invocation.ReadEnd();
                self.SetPresetVisible(aVersion, aIndex, aVisible);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoSetPresetName(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aIndex;
            string aName;
            try
            {
                invocation.ReadStart();
                aIndex = invocation.ReadUint("aIndex");
                aName = invocation.ReadString("aName");
                invocation.ReadEnd();
                self.SetPresetName(aVersion, aIndex, aName);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoDelayMinimum(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aDelay;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.DelayMinimum(aVersion, out aDelay);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteUint("aDelay", aDelay);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoDelayMaximum(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aDelay;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.DelayMaximum(aVersion, out aDelay);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteUint("aDelay", aDelay);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        private static int DoPresetCount(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkDelay1 self = (DvProviderLinnCoUkDelay1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            uint aCount;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.PresetCount(aVersion, out aCount);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            catch (ActionDisabledError)
            {
                invocation.ReportError(501, "Action not implemented"); ;
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML"); ;
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteUint("aCount", aCount);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Must be called for each class instance.  Must be called before Core.Library.Close().
        /// </summary>
        public void Dispose()
        {
            DoDispose();
            GC.SuppressFinalize(this);
        }

        ~DvProviderLinnCoUkDelay1()
        {
            DoDispose();
        }

        private void DoDispose()
        {
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                {
                    return;
                }
                DisposeProvider();
                iHandle = IntPtr.Zero;
            }
            iGch.Free();
        }
    }
}

