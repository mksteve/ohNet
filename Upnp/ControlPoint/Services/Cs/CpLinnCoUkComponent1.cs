using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp;

namespace Zapp
{
    public class CpProxyLinnCoUkComponent1 : CpProxy, IDisposable
    {
        [DllImport("CpLinnCoUkComponent1")]
        static extern IntPtr CpProxyLinnCoUkComponent1Create(IntPtr aDeviceHandle);
        [DllImport("CpLinnCoUkComponent1")]
        static extern void CpProxyLinnCoUkComponent1Destroy(IntPtr aHandle);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncAmplifierEnabled(IntPtr aHandle, uint* aaEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginAmplifierEnabled(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndAmplifierEnabled(IntPtr aHandle, IntPtr aAsync, uint* aaEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncSetAmplifierEnabled(IntPtr aHandle, uint aaEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginSetAmplifierEnabled(IntPtr aHandle, uint aaEnabled, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndSetAmplifierEnabled(IntPtr aHandle, IntPtr aAsync);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncAmplifierAttenuation(IntPtr aHandle, char** aaAttenuation);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginAmplifierAttenuation(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndAmplifierAttenuation(IntPtr aHandle, IntPtr aAsync, char** aaAttenuation);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncSetAmplifierAttenuation(IntPtr aHandle, char* aaAttenuation);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginSetAmplifierAttenuation(IntPtr aHandle, char* aaAttenuation, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndSetAmplifierAttenuation(IntPtr aHandle, IntPtr aAsync);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncSetVolumeControlEnabled(IntPtr aHandle, uint aaEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginSetVolumeControlEnabled(IntPtr aHandle, uint aaEnabled, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndSetVolumeControlEnabled(IntPtr aHandle, IntPtr aAsync);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncVolumeControlEnabled(IntPtr aHandle, uint* aaEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginVolumeControlEnabled(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndVolumeControlEnabled(IntPtr aHandle, IntPtr aAsync, uint* aaEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncSetDigitalAudioOutputRaw(IntPtr aHandle, uint aaRaw);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginSetDigitalAudioOutputRaw(IntPtr aHandle, uint aaRaw, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndSetDigitalAudioOutputRaw(IntPtr aHandle, IntPtr aAsync);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncDigitalAudioOutputRaw(IntPtr aHandle, uint* aaRaw);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginDigitalAudioOutputRaw(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndDigitalAudioOutputRaw(IntPtr aHandle, IntPtr aAsync, uint* aaRaw);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncAmplifierOverTemperature(IntPtr aHandle, uint* aaOverTemperature);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginAmplifierOverTemperature(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndAmplifierOverTemperature(IntPtr aHandle, IntPtr aAsync, uint* aaOverTemperature);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncEthernetLinkConnected(IntPtr aHandle, uint* aaLinkConnected);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginEthernetLinkConnected(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndEthernetLinkConnected(IntPtr aHandle, IntPtr aAsync, uint* aaLinkConnected);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1SyncLocate(IntPtr aHandle);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1BeginLocate(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe int CpProxyLinnCoUkComponent1EndLocate(IntPtr aHandle, IntPtr aAsync);
        [DllImport("CpLinnCoUkComponent1")]
        static extern void CpProxyLinnCoUkComponent1SetPropertyAmplifierEnabledChanged(IntPtr aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern void CpProxyLinnCoUkComponent1SetPropertyAmplifierAttenuationChanged(IntPtr aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern void CpProxyLinnCoUkComponent1SetPropertyVolumeControlEnabledChanged(IntPtr aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern void CpProxyLinnCoUkComponent1SetPropertyDigitalAudioOutputRawChanged(IntPtr aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1PropertyAmplifierEnabled(IntPtr aHandle, uint* aAmplifierEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1PropertyAmplifierAttenuation(IntPtr aHandle, char** aAmplifierAttenuation);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1PropertyVolumeControlEnabled(IntPtr aHandle, uint* aVolumeControlEnabled);
        [DllImport("CpLinnCoUkComponent1")]
        static extern unsafe void CpProxyLinnCoUkComponent1PropertyDigitalAudioOutputRaw(IntPtr aHandle, uint* aDigitalAudioOutputRaw);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(void* aPtr);

        private GCHandle iGch;
        private CallbackPropertyChanged iAmplifierEnabledChanged;
        private CallbackPropertyChanged iAmplifierAttenuationChanged;
        private CallbackPropertyChanged iVolumeControlEnabledChanged;
        private CallbackPropertyChanged iDigitalAudioOutputRawChanged;
        private Callback iCallbackAmplifierEnabledChanged;
        private Callback iCallbackAmplifierAttenuationChanged;
        private Callback iCallbackVolumeControlEnabledChanged;
        private Callback iCallbackDigitalAudioOutputRawChanged;

        public CpProxyLinnCoUkComponent1(CpDevice aDevice)
        {
            iHandle = CpProxyLinnCoUkComponent1Create(aDevice.Handle());
            iGch = GCHandle.Alloc(this);
        }

        public unsafe void SyncAmplifierEnabled(out bool aaEnabled)
        {
			uint aEnabled;
			{
				CpProxyLinnCoUkComponent1SyncAmplifierEnabled(iHandle, &aEnabled);
			}
			aaEnabled = (aEnabled != 0);
        }

        public unsafe void BeginAmplifierEnabled(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginAmplifierEnabled(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndAmplifierEnabled(IntPtr aAsyncHandle, out bool aaEnabled)
        {
			uint aEnabled;
			{
				if (0 != CpProxyLinnCoUkComponent1EndAmplifierEnabled(iHandle, aAsyncHandle, &aEnabled))
				{
					throw(new ProxyError());
				}
			}
			aaEnabled = (aEnabled != 0);
        }

        public unsafe void SyncSetAmplifierEnabled(bool aaEnabled)
        {
			uint aEnabled = (aaEnabled? 1u : 0u);
			{
				CpProxyLinnCoUkComponent1SyncSetAmplifierEnabled(iHandle, aEnabled);
			}
        }

        public unsafe void BeginSetAmplifierEnabled(bool aaEnabled, CallbackAsyncComplete aCallback)
        {
			uint aEnabled = (aaEnabled? 1u : 0u);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginSetAmplifierEnabled(iHandle, aEnabled, iActionComplete, ptr);
        }

        public unsafe void EndSetAmplifierEnabled(IntPtr aAsyncHandle)
        {
			{
				if (0 != CpProxyLinnCoUkComponent1EndSetAmplifierEnabled(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncAmplifierAttenuation(out string aaAttenuation)
        {
			char* aAttenuation;
			{
				CpProxyLinnCoUkComponent1SyncAmplifierAttenuation(iHandle, &aAttenuation);
			}
            aaAttenuation = Marshal.PtrToStringAnsi((IntPtr)aAttenuation);
            ZappFree(aAttenuation);
        }

        public unsafe void BeginAmplifierAttenuation(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginAmplifierAttenuation(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndAmplifierAttenuation(IntPtr aAsyncHandle, out string aaAttenuation)
        {
			char* aAttenuation;
			{
				if (0 != CpProxyLinnCoUkComponent1EndAmplifierAttenuation(iHandle, aAsyncHandle, &aAttenuation))
				{
					throw(new ProxyError());
				}
			}
            aaAttenuation = Marshal.PtrToStringAnsi((IntPtr)aAttenuation);
            ZappFree(aAttenuation);
        }

        public unsafe void SyncSetAmplifierAttenuation(string aaAttenuation)
        {
			char* aAttenuation = (char*)Marshal.StringToHGlobalAnsi(aaAttenuation);
			{
				CpProxyLinnCoUkComponent1SyncSetAmplifierAttenuation(iHandle, aAttenuation);
			}
			Marshal.FreeHGlobal((IntPtr)aAttenuation);
        }

        public unsafe void BeginSetAmplifierAttenuation(string aaAttenuation, CallbackAsyncComplete aCallback)
        {
			char* aAttenuation = (char*)Marshal.StringToHGlobalAnsi(aaAttenuation);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginSetAmplifierAttenuation(iHandle, aAttenuation, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)aAttenuation);
        }

        public unsafe void EndSetAmplifierAttenuation(IntPtr aAsyncHandle)
        {
			{
				if (0 != CpProxyLinnCoUkComponent1EndSetAmplifierAttenuation(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncSetVolumeControlEnabled(bool aaEnabled)
        {
			uint aEnabled = (aaEnabled? 1u : 0u);
			{
				CpProxyLinnCoUkComponent1SyncSetVolumeControlEnabled(iHandle, aEnabled);
			}
        }

        public unsafe void BeginSetVolumeControlEnabled(bool aaEnabled, CallbackAsyncComplete aCallback)
        {
			uint aEnabled = (aaEnabled? 1u : 0u);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginSetVolumeControlEnabled(iHandle, aEnabled, iActionComplete, ptr);
        }

        public unsafe void EndSetVolumeControlEnabled(IntPtr aAsyncHandle)
        {
			{
				if (0 != CpProxyLinnCoUkComponent1EndSetVolumeControlEnabled(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncVolumeControlEnabled(out bool aaEnabled)
        {
			uint aEnabled;
			{
				CpProxyLinnCoUkComponent1SyncVolumeControlEnabled(iHandle, &aEnabled);
			}
			aaEnabled = (aEnabled != 0);
        }

        public unsafe void BeginVolumeControlEnabled(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginVolumeControlEnabled(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndVolumeControlEnabled(IntPtr aAsyncHandle, out bool aaEnabled)
        {
			uint aEnabled;
			{
				if (0 != CpProxyLinnCoUkComponent1EndVolumeControlEnabled(iHandle, aAsyncHandle, &aEnabled))
				{
					throw(new ProxyError());
				}
			}
			aaEnabled = (aEnabled != 0);
        }

        public unsafe void SyncSetDigitalAudioOutputRaw(bool aaRaw)
        {
			uint aRaw = (aaRaw? 1u : 0u);
			{
				CpProxyLinnCoUkComponent1SyncSetDigitalAudioOutputRaw(iHandle, aRaw);
			}
        }

        public unsafe void BeginSetDigitalAudioOutputRaw(bool aaRaw, CallbackAsyncComplete aCallback)
        {
			uint aRaw = (aaRaw? 1u : 0u);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginSetDigitalAudioOutputRaw(iHandle, aRaw, iActionComplete, ptr);
        }

        public unsafe void EndSetDigitalAudioOutputRaw(IntPtr aAsyncHandle)
        {
			{
				if (0 != CpProxyLinnCoUkComponent1EndSetDigitalAudioOutputRaw(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncDigitalAudioOutputRaw(out bool aaRaw)
        {
			uint aRaw;
			{
				CpProxyLinnCoUkComponent1SyncDigitalAudioOutputRaw(iHandle, &aRaw);
			}
			aaRaw = (aRaw != 0);
        }

        public unsafe void BeginDigitalAudioOutputRaw(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginDigitalAudioOutputRaw(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndDigitalAudioOutputRaw(IntPtr aAsyncHandle, out bool aaRaw)
        {
			uint aRaw;
			{
				if (0 != CpProxyLinnCoUkComponent1EndDigitalAudioOutputRaw(iHandle, aAsyncHandle, &aRaw))
				{
					throw(new ProxyError());
				}
			}
			aaRaw = (aRaw != 0);
        }

        public unsafe void SyncAmplifierOverTemperature(out bool aaOverTemperature)
        {
			uint aOverTemperature;
			{
				CpProxyLinnCoUkComponent1SyncAmplifierOverTemperature(iHandle, &aOverTemperature);
			}
			aaOverTemperature = (aOverTemperature != 0);
        }

        public unsafe void BeginAmplifierOverTemperature(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginAmplifierOverTemperature(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndAmplifierOverTemperature(IntPtr aAsyncHandle, out bool aaOverTemperature)
        {
			uint aOverTemperature;
			{
				if (0 != CpProxyLinnCoUkComponent1EndAmplifierOverTemperature(iHandle, aAsyncHandle, &aOverTemperature))
				{
					throw(new ProxyError());
				}
			}
			aaOverTemperature = (aOverTemperature != 0);
        }

        public unsafe void SyncEthernetLinkConnected(out bool aaLinkConnected)
        {
			uint aLinkConnected;
			{
				CpProxyLinnCoUkComponent1SyncEthernetLinkConnected(iHandle, &aLinkConnected);
			}
			aaLinkConnected = (aLinkConnected != 0);
        }

        public unsafe void BeginEthernetLinkConnected(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginEthernetLinkConnected(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndEthernetLinkConnected(IntPtr aAsyncHandle, out bool aaLinkConnected)
        {
			uint aLinkConnected;
			{
				if (0 != CpProxyLinnCoUkComponent1EndEthernetLinkConnected(iHandle, aAsyncHandle, &aLinkConnected))
				{
					throw(new ProxyError());
				}
			}
			aaLinkConnected = (aLinkConnected != 0);
        }

        public unsafe void SyncLocate()
        {
			{
				CpProxyLinnCoUkComponent1SyncLocate(iHandle);
			}
        }

        public unsafe void BeginLocate(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyLinnCoUkComponent1BeginLocate(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndLocate(IntPtr aAsyncHandle)
        {
			{
				if (0 != CpProxyLinnCoUkComponent1EndLocate(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public void SetPropertyAmplifierEnabledChanged(CallbackPropertyChanged aAmplifierEnabledChanged)
        {
            iAmplifierEnabledChanged = aAmplifierEnabledChanged;
            iCallbackAmplifierEnabledChanged = new Callback(PropertyAmplifierEnabledChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyLinnCoUkComponent1SetPropertyAmplifierEnabledChanged(iHandle, iCallbackAmplifierEnabledChanged, ptr);
        }

        private void PropertyAmplifierEnabledChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyLinnCoUkComponent1 self = (CpProxyLinnCoUkComponent1)gch.Target;
            self.iAmplifierEnabledChanged();
        }

        public void SetPropertyAmplifierAttenuationChanged(CallbackPropertyChanged aAmplifierAttenuationChanged)
        {
            iAmplifierAttenuationChanged = aAmplifierAttenuationChanged;
            iCallbackAmplifierAttenuationChanged = new Callback(PropertyAmplifierAttenuationChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyLinnCoUkComponent1SetPropertyAmplifierAttenuationChanged(iHandle, iCallbackAmplifierAttenuationChanged, ptr);
        }

        private void PropertyAmplifierAttenuationChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyLinnCoUkComponent1 self = (CpProxyLinnCoUkComponent1)gch.Target;
            self.iAmplifierAttenuationChanged();
        }

        public void SetPropertyVolumeControlEnabledChanged(CallbackPropertyChanged aVolumeControlEnabledChanged)
        {
            iVolumeControlEnabledChanged = aVolumeControlEnabledChanged;
            iCallbackVolumeControlEnabledChanged = new Callback(PropertyVolumeControlEnabledChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyLinnCoUkComponent1SetPropertyVolumeControlEnabledChanged(iHandle, iCallbackVolumeControlEnabledChanged, ptr);
        }

        private void PropertyVolumeControlEnabledChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyLinnCoUkComponent1 self = (CpProxyLinnCoUkComponent1)gch.Target;
            self.iVolumeControlEnabledChanged();
        }

        public void SetPropertyDigitalAudioOutputRawChanged(CallbackPropertyChanged aDigitalAudioOutputRawChanged)
        {
            iDigitalAudioOutputRawChanged = aDigitalAudioOutputRawChanged;
            iCallbackDigitalAudioOutputRawChanged = new Callback(PropertyDigitalAudioOutputRawChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyLinnCoUkComponent1SetPropertyDigitalAudioOutputRawChanged(iHandle, iCallbackDigitalAudioOutputRawChanged, ptr);
        }

        private void PropertyDigitalAudioOutputRawChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyLinnCoUkComponent1 self = (CpProxyLinnCoUkComponent1)gch.Target;
            self.iDigitalAudioOutputRawChanged();
        }

        public unsafe void PropertyAmplifierEnabled(out bool aAmplifierEnabled)
        {
			uint amplifierEnabled;
	        CpProxyLinnCoUkComponent1PropertyAmplifierEnabled(iHandle, &amplifierEnabled);
			aAmplifierEnabled = (amplifierEnabled != 0);
        }

        public unsafe void PropertyAmplifierAttenuation(out string aAmplifierAttenuation)
        {
			char* ptr;
            CpProxyLinnCoUkComponent1PropertyAmplifierAttenuation(iHandle, &ptr);
            aAmplifierAttenuation = Marshal.PtrToStringAnsi((IntPtr)ptr);
            ZappFree(ptr);
        }

        public unsafe void PropertyVolumeControlEnabled(out bool aVolumeControlEnabled)
        {
			uint volumeControlEnabled;
	        CpProxyLinnCoUkComponent1PropertyVolumeControlEnabled(iHandle, &volumeControlEnabled);
			aVolumeControlEnabled = (volumeControlEnabled != 0);
        }

        public unsafe void PropertyDigitalAudioOutputRaw(out bool aDigitalAudioOutputRaw)
        {
			uint digitalAudioOutputRaw;
	        CpProxyLinnCoUkComponent1PropertyDigitalAudioOutputRaw(iHandle, &digitalAudioOutputRaw);
			aDigitalAudioOutputRaw = (digitalAudioOutputRaw != 0);
        }

        public void Dispose()
        {
            DoDispose(true);
        }

        ~CpProxyLinnCoUkComponent1()
        {
            DoDispose(false);
        }

        private void DoDispose(bool aDisposing)
        {
            IntPtr handle;
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                {
                    return;
                }
                handle = iHandle;
                iHandle = IntPtr.Zero;
            }
            CpProxyLinnCoUkComponent1Destroy(handle);
            iGch.Free();
            if (aDisposing)
            {
                GC.SuppressFinalize(this);
            }
            else
            {
                DisposeProxy();
            }
        }
    }
}

