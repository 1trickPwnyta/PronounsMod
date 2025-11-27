using Verse;

namespace PronounsMod
{
    public class PronounDef : Def
    {
        public string subjective;
        public string objective;
        public string possessive;
        public VerbForm verbForm = VerbForm.Singular;
        public float commonalityFemale;
        public float commonalityMale;
        public float commonalityNone;

        public float GetCommonality(Gender gender)
        {
            if (gender == Gender.Female)
            {
                return commonalityFemale;
            }
            else if (gender == Gender.Male)
            {
                return commonalityMale;
            }
            else
            {
                return commonalityNone;
            }
        }
    }
}
