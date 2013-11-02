using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Phone.Speech.Synthesis;

namespace EcuaVoiceMobile
{
    class VozDigitalizada
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public async void Speak(string lectura)
        {
            try
            {
                var voices = InstalledVoices.All.Where(v => v.Language == "es-ES").OrderByDescending(v => v.Gender);
                VoiceGender gender = VoiceGender.Female;
                synth.SetVoice(voices.Where(v => v.Gender == gender).FirstOrDefault());
                await synth.SpeakTextAsync(lectura);
            }
            catch (Exception ex)
            { }
        }
        public void Stop()
        {
            synth.CancelAll();
        }
        public void Dispose()
        {
            synth.Dispose();
        }       
    }
}
