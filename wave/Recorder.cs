using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vtmblip.wave
{
    public class Recorder
    {
        private unsafe void DataArrived(IntPtr data, int size)
        {
            cb.Upload(data.ToPointer(), size);
        }

        WaveLib.WaveInRecorder m_Recorder;
        //VorbisEnc.VorbisEnc ve;
        VorbisEnc.FlacEncoder ve;
        VorbisEnc.CircleBuffer cb;
        IntPtr filepath;

        public unsafe Recorder(string tempfilepath)
        {
            cb = new VorbisEnc.CircleBuffer();
            //ve = new VorbisEnc.VorbisEnc();
            ve = new VorbisEnc.FlacEncoder();
            //byte[] data = Encoding.GetBytes(tempfilepath);
            //filepath = System.Runtime.InteropServices.Marshal.AllocHGlobal(data.Length + 1);
            
            //System.Runtime.InteropServices.Marshal.Copy(data, 0, filepath, data.Length);
            //ve.Initialise((sbyte*)filepath.ToPointer());
            ve.Initialise((sbyte*)System.Runtime.InteropServices.Marshal.StringToHGlobalUni(tempfilepath).ToPointer());
            //System.Runtime.InteropServices.Marshal.FreeHGlobal(filepath);//need anymore?

            System.Threading.Thread th = new System.Threading.Thread(EncodeData);

            WaveLib.WaveFormat fmt = new WaveLib.WaveFormat(16000, 16, 1);
            m_Recorder = new WaveLib.WaveInRecorder(-1, fmt, 4096, 4, new WaveLib.BufferDoneEventHandler(DataArrived));

            th.Start();
        }
        ~Recorder()
        {
            //System.Runtime.InteropServices.Marshal.FreeHGlobal(filepath);
        }
        bool StopThread;
        public bool AllDone = false;
        public void Stop()
        {
            m_Recorder.Dispose();
            StopThread = true;
            cb.Dispose();
        }
        unsafe void EncodeData()
        {
            IntPtr datax = System.Runtime.InteropServices.Marshal.AllocHGlobal(4096);
            sbyte* data = (sbyte*)datax.ToPointer();
            while (!StopThread)
            {
                System.Threading.Thread.Sleep(10);
                while (cb.getNeedForUpdate() < 4096 * 4)
                {
                    cb.Download(data, 4096);
                    ve.Encode(data, 4096);
                }
            }
            System.Runtime.InteropServices.Marshal.FreeHGlobal(datax);
            ve.Close();

            AllDone = true;
        }
    }
}
