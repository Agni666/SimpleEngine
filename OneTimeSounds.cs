using System;
using System.IO;
using System.Threading;
using SharpDX.Multimedia;
using SharpDX.XAudio2;


namespace ProstySilnik
{
    public class OneTimeSounds : MonoBehaviour
    {
        pvar xaudio2 = new XAudio2();
        var masteringVoice = new MasteringVoice(xaudio2);
        string sound = "Sound1.waw";
        PLaySound(xaudio2 , sound);

        masteringVoice.Dispose();
        xaudio2.Dispose();
    }
}
