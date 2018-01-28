#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkMusicSyncCallbackInfo : AkCallbackInfo {
  private global::System.IntPtr swigCPtr;

  internal AkMusicSyncCallbackInfo(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkMusicSyncCallbackInfo obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal override void setCPtr(global::System.IntPtr cPtr) {
    base.setCPtr(AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(cPtr));
    swigCPtr = cPtr;
  }

  ~AkMusicSyncCallbackInfo() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkMusicSyncCallbackInfo(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint playingID { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_playingID_get(swigCPtr); } 
  }

  public int segmentInfo_iCurrentPosition { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(swigCPtr); } 
  }

  public int segmentInfo_iPreEntryDuration { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(swigCPtr); } 
  }

  public int segmentInfo_iActiveDuration { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(swigCPtr); } 
  }

  public int segmentInfo_iPostExitDuration { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(swigCPtr); } 
  }

  public int segmentInfo_iRemainingLookAheadTime { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(swigCPtr); } 
  }

  public float segmentInfo_fBeatDuration { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(swigCPtr); } 
  }

  public float segmentInfo_fBarDuration { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(swigCPtr); } 
  }

  public float segmentInfo_fGridDuration { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(swigCPtr); } 
  }

  public float segmentInfo_fGridOffset { get { return AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(swigCPtr); } 
  }

  public AkCallbackType musicSyncType { get { return (AkCallbackType)AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(swigCPtr); } 
  }

  public string userCueName { get { return AkSoundEngine.StringFromIntPtrString(AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_userCueName_get(swigCPtr)); } 
  }

  public AkMusicSyncCallbackInfo() : this(AkSoundEnginePINVOKE.CSharp_new_AkMusicSyncCallbackInfo(), true) {
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.