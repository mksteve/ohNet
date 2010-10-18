using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp;

namespace Zapp
{
    public class CpProxyUpnpOrgConnectionManager2 : CpProxy, IDisposable
    {
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern IntPtr CpProxyUpnpOrgConnectionManager2Create(IntPtr aDeviceHandle);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern void CpProxyUpnpOrgConnectionManager2Destroy(IntPtr aHandle);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2SyncGetProtocolInfo(IntPtr aHandle, char** aSource, char** aSink);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2BeginGetProtocolInfo(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe int CpProxyUpnpOrgConnectionManager2EndGetProtocolInfo(IntPtr aHandle, IntPtr aAsync, char** aSource, char** aSink);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2SyncPrepareForConnection(IntPtr aHandle, char* aRemoteProtocolInfo, char* aPeerConnectionManager, int aPeerConnectionID, char* aDirection, int* aConnectionID, int* aAVTransportID, int* aRcsID);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2BeginPrepareForConnection(IntPtr aHandle, char* aRemoteProtocolInfo, char* aPeerConnectionManager, int aPeerConnectionID, char* aDirection, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe int CpProxyUpnpOrgConnectionManager2EndPrepareForConnection(IntPtr aHandle, IntPtr aAsync, int* aConnectionID, int* aAVTransportID, int* aRcsID);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2SyncConnectionComplete(IntPtr aHandle, int aConnectionID);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2BeginConnectionComplete(IntPtr aHandle, int aConnectionID, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe int CpProxyUpnpOrgConnectionManager2EndConnectionComplete(IntPtr aHandle, IntPtr aAsync);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2SyncGetCurrentConnectionIDs(IntPtr aHandle, char** aConnectionIDs);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2BeginGetCurrentConnectionIDs(IntPtr aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe int CpProxyUpnpOrgConnectionManager2EndGetCurrentConnectionIDs(IntPtr aHandle, IntPtr aAsync, char** aConnectionIDs);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2SyncGetCurrentConnectionInfo(IntPtr aHandle, int aConnectionID, int* aRcsID, int* aAVTransportID, char** aProtocolInfo, char** aPeerConnectionManager, int* aPeerConnectionID, char** aDirection, char** aStatus);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2BeginGetCurrentConnectionInfo(IntPtr aHandle, int aConnectionID, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe int CpProxyUpnpOrgConnectionManager2EndGetCurrentConnectionInfo(IntPtr aHandle, IntPtr aAsync, int* aRcsID, int* aAVTransportID, char** aProtocolInfo, char** aPeerConnectionManager, int* aPeerConnectionID, char** aDirection, char** aStatus);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern void CpProxyUpnpOrgConnectionManager2SetPropertySourceProtocolInfoChanged(IntPtr aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern void CpProxyUpnpOrgConnectionManager2SetPropertySinkProtocolInfoChanged(IntPtr aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern void CpProxyUpnpOrgConnectionManager2SetPropertyCurrentConnectionIDsChanged(IntPtr aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2PropertySourceProtocolInfo(IntPtr aHandle, char** aSourceProtocolInfo);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2PropertySinkProtocolInfo(IntPtr aHandle, char** aSinkProtocolInfo);
        [DllImport("CpUpnpOrgConnectionManager2")]
        static extern unsafe void CpProxyUpnpOrgConnectionManager2PropertyCurrentConnectionIDs(IntPtr aHandle, char** aCurrentConnectionIDs);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(void* aPtr);

        private GCHandle iGch;
        private CallbackPropertyChanged iSourceProtocolInfoChanged;
        private CallbackPropertyChanged iSinkProtocolInfoChanged;
        private CallbackPropertyChanged iCurrentConnectionIDsChanged;
        private Callback iCallbackSourceProtocolInfoChanged;
        private Callback iCallbackSinkProtocolInfoChanged;
        private Callback iCallbackCurrentConnectionIDsChanged;

        public CpProxyUpnpOrgConnectionManager2(CpDevice aDevice)
        {
            iHandle = CpProxyUpnpOrgConnectionManager2Create(aDevice.Handle());
            iGch = GCHandle.Alloc(this);
        }

        public unsafe void SyncGetProtocolInfo(out string aSource, out string aSink)
        {
			char* source;
			char* sink;
			{
				CpProxyUpnpOrgConnectionManager2SyncGetProtocolInfo(iHandle, &source, &sink);
			}
            aSource = Marshal.PtrToStringAnsi((IntPtr)source);
            ZappFree(source);
            aSink = Marshal.PtrToStringAnsi((IntPtr)sink);
            ZappFree(sink);
        }

        public unsafe void BeginGetProtocolInfo(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgConnectionManager2BeginGetProtocolInfo(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndGetProtocolInfo(IntPtr aAsyncHandle, out string aSource, out string aSink)
        {
			char* source;
			char* sink;
			{
				if (0 != CpProxyUpnpOrgConnectionManager2EndGetProtocolInfo(iHandle, aAsyncHandle, &source, &sink))
				{
					throw(new ProxyError());
				}
			}
            aSource = Marshal.PtrToStringAnsi((IntPtr)source);
            ZappFree(source);
            aSink = Marshal.PtrToStringAnsi((IntPtr)sink);
            ZappFree(sink);
        }

        public unsafe void SyncPrepareForConnection(string aRemoteProtocolInfo, string aPeerConnectionManager, int aPeerConnectionID, string aDirection, out int aConnectionID, out int aAVTransportID, out int aRcsID)
        {
			char* remoteProtocolInfo = (char*)Marshal.StringToHGlobalAnsi(aRemoteProtocolInfo);
			char* peerConnectionManager = (char*)Marshal.StringToHGlobalAnsi(aPeerConnectionManager);
			char* direction = (char*)Marshal.StringToHGlobalAnsi(aDirection);
			fixed (int* connectionID = &aConnectionID)
			fixed (int* aVTransportID = &aAVTransportID)
			fixed (int* rcsID = &aRcsID)
			{
				CpProxyUpnpOrgConnectionManager2SyncPrepareForConnection(iHandle, remoteProtocolInfo, peerConnectionManager, aPeerConnectionID, direction, connectionID, aVTransportID, rcsID);
			}
			Marshal.FreeHGlobal((IntPtr)remoteProtocolInfo);
			Marshal.FreeHGlobal((IntPtr)peerConnectionManager);
			Marshal.FreeHGlobal((IntPtr)direction);
        }

        public unsafe void BeginPrepareForConnection(string aRemoteProtocolInfo, string aPeerConnectionManager, int aPeerConnectionID, string aDirection, CallbackAsyncComplete aCallback)
        {
			char* remoteProtocolInfo = (char*)Marshal.StringToHGlobalAnsi(aRemoteProtocolInfo);
			char* peerConnectionManager = (char*)Marshal.StringToHGlobalAnsi(aPeerConnectionManager);
			char* direction = (char*)Marshal.StringToHGlobalAnsi(aDirection);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgConnectionManager2BeginPrepareForConnection(iHandle, remoteProtocolInfo, peerConnectionManager, aPeerConnectionID, direction, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)remoteProtocolInfo);
			Marshal.FreeHGlobal((IntPtr)peerConnectionManager);
			Marshal.FreeHGlobal((IntPtr)direction);
        }

        public unsafe void EndPrepareForConnection(IntPtr aAsyncHandle, out int aConnectionID, out int aAVTransportID, out int aRcsID)
        {
			fixed (int* connectionID = &aConnectionID)
			fixed (int* aVTransportID = &aAVTransportID)
			fixed (int* rcsID = &aRcsID)
			{
				if (0 != CpProxyUpnpOrgConnectionManager2EndPrepareForConnection(iHandle, aAsyncHandle, connectionID, aVTransportID, rcsID))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncConnectionComplete(int aConnectionID)
        {
			{
				CpProxyUpnpOrgConnectionManager2SyncConnectionComplete(iHandle, aConnectionID);
			}
        }

        public unsafe void BeginConnectionComplete(int aConnectionID, CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgConnectionManager2BeginConnectionComplete(iHandle, aConnectionID, iActionComplete, ptr);
        }

        public unsafe void EndConnectionComplete(IntPtr aAsyncHandle)
        {
			{
				if (0 != CpProxyUpnpOrgConnectionManager2EndConnectionComplete(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncGetCurrentConnectionIDs(out string aConnectionIDs)
        {
			char* connectionIDs;
			{
				CpProxyUpnpOrgConnectionManager2SyncGetCurrentConnectionIDs(iHandle, &connectionIDs);
			}
            aConnectionIDs = Marshal.PtrToStringAnsi((IntPtr)connectionIDs);
            ZappFree(connectionIDs);
        }

        public unsafe void BeginGetCurrentConnectionIDs(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgConnectionManager2BeginGetCurrentConnectionIDs(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndGetCurrentConnectionIDs(IntPtr aAsyncHandle, out string aConnectionIDs)
        {
			char* connectionIDs;
			{
				if (0 != CpProxyUpnpOrgConnectionManager2EndGetCurrentConnectionIDs(iHandle, aAsyncHandle, &connectionIDs))
				{
					throw(new ProxyError());
				}
			}
            aConnectionIDs = Marshal.PtrToStringAnsi((IntPtr)connectionIDs);
            ZappFree(connectionIDs);
        }

        public unsafe void SyncGetCurrentConnectionInfo(int aConnectionID, out int aRcsID, out int aAVTransportID, out string aProtocolInfo, out string aPeerConnectionManager, out int aPeerConnectionID, out string aDirection, out string aStatus)
        {
			char* protocolInfo;
			char* peerConnectionManager;
			char* direction;
			char* status;
			fixed (int* rcsID = &aRcsID)
			fixed (int* aVTransportID = &aAVTransportID)
			fixed (int* peerConnectionID = &aPeerConnectionID)
			{
				CpProxyUpnpOrgConnectionManager2SyncGetCurrentConnectionInfo(iHandle, aConnectionID, rcsID, aVTransportID, &protocolInfo, &peerConnectionManager, peerConnectionID, &direction, &status);
			}
            aProtocolInfo = Marshal.PtrToStringAnsi((IntPtr)protocolInfo);
            ZappFree(protocolInfo);
            aPeerConnectionManager = Marshal.PtrToStringAnsi((IntPtr)peerConnectionManager);
            ZappFree(peerConnectionManager);
            aDirection = Marshal.PtrToStringAnsi((IntPtr)direction);
            ZappFree(direction);
            aStatus = Marshal.PtrToStringAnsi((IntPtr)status);
            ZappFree(status);
        }

        public unsafe void BeginGetCurrentConnectionInfo(int aConnectionID, CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgConnectionManager2BeginGetCurrentConnectionInfo(iHandle, aConnectionID, iActionComplete, ptr);
        }

        public unsafe void EndGetCurrentConnectionInfo(IntPtr aAsyncHandle, out int aRcsID, out int aAVTransportID, out string aProtocolInfo, out string aPeerConnectionManager, out int aPeerConnectionID, out string aDirection, out string aStatus)
        {
			char* protocolInfo;
			char* peerConnectionManager;
			char* direction;
			char* status;
			fixed (int* rcsID = &aRcsID)
			fixed (int* aVTransportID = &aAVTransportID)
			fixed (int* peerConnectionID = &aPeerConnectionID)
			{
				if (0 != CpProxyUpnpOrgConnectionManager2EndGetCurrentConnectionInfo(iHandle, aAsyncHandle, rcsID, aVTransportID, &protocolInfo, &peerConnectionManager, peerConnectionID, &direction, &status))
				{
					throw(new ProxyError());
				}
			}
            aProtocolInfo = Marshal.PtrToStringAnsi((IntPtr)protocolInfo);
            ZappFree(protocolInfo);
            aPeerConnectionManager = Marshal.PtrToStringAnsi((IntPtr)peerConnectionManager);
            ZappFree(peerConnectionManager);
            aDirection = Marshal.PtrToStringAnsi((IntPtr)direction);
            ZappFree(direction);
            aStatus = Marshal.PtrToStringAnsi((IntPtr)status);
            ZappFree(status);
        }

        public void SetPropertySourceProtocolInfoChanged(CallbackPropertyChanged aSourceProtocolInfoChanged)
        {
            iSourceProtocolInfoChanged = aSourceProtocolInfoChanged;
            iCallbackSourceProtocolInfoChanged = new Callback(PropertySourceProtocolInfoChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyUpnpOrgConnectionManager2SetPropertySourceProtocolInfoChanged(iHandle, iCallbackSourceProtocolInfoChanged, ptr);
        }

        private void PropertySourceProtocolInfoChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyUpnpOrgConnectionManager2 self = (CpProxyUpnpOrgConnectionManager2)gch.Target;
            self.iSourceProtocolInfoChanged();
        }

        public void SetPropertySinkProtocolInfoChanged(CallbackPropertyChanged aSinkProtocolInfoChanged)
        {
            iSinkProtocolInfoChanged = aSinkProtocolInfoChanged;
            iCallbackSinkProtocolInfoChanged = new Callback(PropertySinkProtocolInfoChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyUpnpOrgConnectionManager2SetPropertySinkProtocolInfoChanged(iHandle, iCallbackSinkProtocolInfoChanged, ptr);
        }

        private void PropertySinkProtocolInfoChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyUpnpOrgConnectionManager2 self = (CpProxyUpnpOrgConnectionManager2)gch.Target;
            self.iSinkProtocolInfoChanged();
        }

        public void SetPropertyCurrentConnectionIDsChanged(CallbackPropertyChanged aCurrentConnectionIDsChanged)
        {
            iCurrentConnectionIDsChanged = aCurrentConnectionIDsChanged;
            iCallbackCurrentConnectionIDsChanged = new Callback(PropertyCurrentConnectionIDsChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyUpnpOrgConnectionManager2SetPropertyCurrentConnectionIDsChanged(iHandle, iCallbackCurrentConnectionIDsChanged, ptr);
        }

        private void PropertyCurrentConnectionIDsChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyUpnpOrgConnectionManager2 self = (CpProxyUpnpOrgConnectionManager2)gch.Target;
            self.iCurrentConnectionIDsChanged();
        }

        public unsafe void PropertySourceProtocolInfo(out string aSourceProtocolInfo)
        {
			char* ptr;
            CpProxyUpnpOrgConnectionManager2PropertySourceProtocolInfo(iHandle, &ptr);
            aSourceProtocolInfo = Marshal.PtrToStringAnsi((IntPtr)ptr);
            ZappFree(ptr);
        }

        public unsafe void PropertySinkProtocolInfo(out string aSinkProtocolInfo)
        {
			char* ptr;
            CpProxyUpnpOrgConnectionManager2PropertySinkProtocolInfo(iHandle, &ptr);
            aSinkProtocolInfo = Marshal.PtrToStringAnsi((IntPtr)ptr);
            ZappFree(ptr);
        }

        public unsafe void PropertyCurrentConnectionIDs(out string aCurrentConnectionIDs)
        {
			char* ptr;
            CpProxyUpnpOrgConnectionManager2PropertyCurrentConnectionIDs(iHandle, &ptr);
            aCurrentConnectionIDs = Marshal.PtrToStringAnsi((IntPtr)ptr);
            ZappFree(ptr);
        }

        public void Dispose()
        {
            DoDispose(true);
        }

        ~CpProxyUpnpOrgConnectionManager2()
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
            CpProxyUpnpOrgConnectionManager2Destroy(handle);
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

