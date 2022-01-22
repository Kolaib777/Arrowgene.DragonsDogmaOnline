﻿using Arrowgene.Buffers;

namespace Arrowgene.Ddon.Shared.Entity.Structure
{
    public class CDataEditInfo
    {
        public byte Sex;
        public byte Voice;
        public ushort VoicePitch;
        public byte Personality;
        public byte SpeechFreq;
        public byte BodyType;
        public byte Hair;
        public byte Beard;
        public byte Makeup;
        public byte Scar;
        public byte EyePresetNo;
        public byte NosePresetNo;
        public byte MouthPresetNo;
        public byte EyebrowTexNo;
        public byte ColorSkin;
        public byte ColorHair;
        public byte ColorBeard;
        public byte ColorEyebrow;
        public byte ColorREye;
        public byte ColorLEye;
        public byte ColorMakeup;
        public ushort Sokutobu;
        public ushort Hitai;
        public ushort MimiJyouge;
        public ushort Kannkaku;
        public ushort MabisasiJyouge;
        public ushort HanakuchiJyouge;
        public ushort AgoSakiHaba;
        public ushort AgoZengo;
        public ushort AgoSakiJyouge;
        public ushort HitomiOokisa;
        public ushort MeOokisa;
        public ushort MeKaiten;
        public ushort MayuKaiten;
        public ushort MimiOokisa;
        public ushort MimiMuki;
        public ushort ElfMimi;
        public ushort MikenTakasa;
        public ushort MikenHaba;
        public ushort HohoboneRyou;
        public ushort HohoboneJyouge;
        public ushort Hohoniku;
        public ushort ErahoneJyouge;
        public ushort ErahoneHaba;
        public ushort HanaJyouge;
        public ushort HanaHaba;
        public ushort HanaTakasa;
        public ushort HanaKakudo;
        public ushort KuchiHaba;
        public ushort KuchiAtsusa;
        public ushort EyebrowUVOffsetX;
        public ushort EyebrowUVOffsetY;
        public ushort Wrinkle;
        public ushort WrinkleAlbedoBlendRate;
        public ushort WrinkleDetailNormalPower;
        public ushort MuscleAlbedoBlendRate;
        public ushort MuscleDetailNormalPower;
        public ushort Height;
        public ushort HeadSize;
        public ushort NeckOffset;
        public ushort NeckScale;
        public ushort UpperBodyScaleX;
        public ushort BellySize;
        public ushort TeatScale;
        public ushort TekubiSize;
        public ushort KoshiOffset;
        public ushort KoshiSize;
        public ushort AnkleOffset;
        public ushort Fat;
        public ushort Muscle;
        public ushort MotionFilter;
    }

    public class CDataEditInfoSerializer : EntitySerializer<CDataEditInfo>
    {
        public override void Write(IBuffer buffer, CDataEditInfo obj)
        {
            WriteByte(buffer, obj.Sex);
            WriteByte(buffer, obj.Voice);
            WriteUInt16(buffer, obj.VoicePitch);
            WriteByte(buffer, obj.Personality);
            WriteByte(buffer, obj.SpeechFreq);
            WriteByte(buffer, obj.BodyType);
            WriteByte(buffer, obj.Hair);
            WriteByte(buffer, obj.Beard);
            WriteByte(buffer, obj.Makeup); //10
            WriteByte(buffer, obj.Scar);
            WriteByte(buffer, obj.EyePresetNo);
            WriteByte(buffer, obj.NosePresetNo);
            WriteByte(buffer, obj.MouthPresetNo);
            WriteByte(buffer, obj.EyebrowTexNo);
            WriteByte(buffer, obj.ColorSkin);
            WriteByte(buffer, obj.ColorHair);
            WriteByte(buffer, obj.ColorBeard);
            WriteByte(buffer, obj.ColorEyebrow);
            WriteByte(buffer, obj.ColorREye); //20
            WriteByte(buffer, obj.ColorLEye);
            WriteByte(buffer, obj.ColorMakeup); 
            WriteUInt16(buffer, obj.Sokutobu);
            WriteUInt16(buffer, obj.Hitai);
            WriteUInt16(buffer, obj.MimiJyouge);
            WriteUInt16(buffer, obj.Kannkaku); //30
            WriteUInt16(buffer, obj.MabisasiJyouge);
            WriteUInt16(buffer, obj.HanakuchiJyouge);
            WriteUInt16(buffer, obj.AgoSakiHaba);
            WriteUInt16(buffer, obj.AgoZengo);
            WriteUInt16(buffer, obj.AgoSakiJyouge); //40
            WriteUInt16(buffer, obj.HitomiOokisa);
            WriteUInt16(buffer, obj.MeOokisa);
            WriteUInt16(buffer, obj.MeKaiten);
            WriteUInt16(buffer, obj.MayuKaiten);
            WriteUInt16(buffer, obj.MimiOokisa); //50
            WriteUInt16(buffer, obj.MimiMuki);
            WriteUInt16(buffer, obj.ElfMimi);
            WriteUInt16(buffer, obj.MikenTakasa);
            WriteUInt16(buffer, obj.MikenHaba);
            WriteUInt16(buffer, obj.HohoboneRyou); //60
            WriteUInt16(buffer, obj.HohoboneJyouge);
            WriteUInt16(buffer, obj.Hohoniku);
            WriteUInt16(buffer, obj.ErahoneJyouge);
            WriteUInt16(buffer, obj.ErahoneHaba);
            WriteUInt16(buffer, obj.HanaJyouge); //70
            WriteUInt16(buffer, obj.HanaHaba);
            WriteUInt16(buffer, obj.HanaTakasa);
            WriteUInt16(buffer, obj.HanaKakudo);
            WriteUInt16(buffer, obj.KuchiHaba);
            WriteUInt16(buffer, obj.KuchiAtsusa);
            WriteUInt16(buffer, obj.EyebrowUVOffsetX);
            WriteUInt16(buffer, obj.EyebrowUVOffsetY);
            WriteUInt16(buffer, obj.Wrinkle);
            WriteUInt16(buffer, obj.WrinkleAlbedoBlendRate);
            WriteUInt16(buffer, obj.WrinkleDetailNormalPower);
            WriteUInt16(buffer, obj.MuscleAlbedoBlendRate);
            WriteUInt16(buffer, obj.MuscleDetailNormalPower);
            WriteUInt16(buffer, obj.Height);
            WriteUInt16(buffer, obj.HeadSize);
            WriteUInt16(buffer, obj.NeckOffset);
            WriteUInt16(buffer, obj.NeckScale);
            WriteUInt16(buffer, obj.UpperBodyScaleX);
            WriteUInt16(buffer, obj.BellySize);
            WriteUInt16(buffer, obj.TeatScale);
            WriteUInt16(buffer, obj.TekubiSize);
            WriteUInt16(buffer, obj.KoshiOffset);
            WriteUInt16(buffer, obj.KoshiSize);
            WriteUInt16(buffer, obj.AnkleOffset);
            WriteUInt16(buffer, obj.Fat);
            WriteUInt16(buffer, obj.Muscle);
            WriteUInt16(buffer, obj.MotionFilter);
        }

        public override CDataEditInfo Read(IBuffer buffer)
        {
            CDataEditInfo obj = new CDataEditInfo();
            obj.Sex = ReadByte(buffer);
            obj.Voice = ReadByte(buffer);
            obj.VoicePitch = ReadUInt16(buffer);
            obj.Personality = ReadByte(buffer);
            obj.SpeechFreq = ReadByte(buffer);
            obj.BodyType = ReadByte(buffer);
            obj.Hair = ReadByte(buffer);
            obj.Beard = ReadByte(buffer);
            obj.Makeup = ReadByte(buffer);
            obj.Scar = ReadByte(buffer);
            obj.EyePresetNo = ReadByte(buffer);
            obj.NosePresetNo = ReadByte(buffer);
            obj.MouthPresetNo = ReadByte(buffer);
            obj.EyebrowTexNo = ReadByte(buffer);
            obj.ColorSkin = ReadByte(buffer);
            obj.ColorHair = ReadByte(buffer);
            obj.ColorBeard = ReadByte(buffer);
            obj.ColorEyebrow = ReadByte(buffer);
            obj.ColorREye = ReadByte(buffer);
            obj.ColorLEye = ReadByte(buffer);
            obj.ColorMakeup = ReadByte(buffer);
            obj.Sokutobu = ReadUInt16(buffer);
            obj.Hitai = ReadUInt16(buffer);
            obj.MimiJyouge = ReadUInt16(buffer);
            obj.Kannkaku = ReadUInt16(buffer);
            obj.MabisasiJyouge = ReadUInt16(buffer);
            obj.HanakuchiJyouge = ReadUInt16(buffer);
            obj.AgoSakiHaba = ReadUInt16(buffer);
            obj.AgoZengo = ReadUInt16(buffer);
            obj.AgoSakiJyouge = ReadUInt16(buffer);
            obj.HitomiOokisa = ReadUInt16(buffer);
            obj.MeOokisa = ReadUInt16(buffer);
            obj.MeKaiten = ReadUInt16(buffer);
            obj.MayuKaiten = ReadUInt16(buffer);
            obj.MimiOokisa = ReadUInt16(buffer);
            obj.MimiMuki = ReadUInt16(buffer);
            obj.ElfMimi = ReadUInt16(buffer);
            obj.MikenTakasa = ReadUInt16(buffer);
            obj.MikenHaba = ReadUInt16(buffer);
            obj.HohoboneRyou = ReadUInt16(buffer);
            obj.HohoboneJyouge = ReadUInt16(buffer);
            obj.Hohoniku = ReadUInt16(buffer);
            obj.ErahoneJyouge = ReadUInt16(buffer);
            obj.ErahoneHaba = ReadUInt16(buffer);
            obj.HanaJyouge = ReadUInt16(buffer);
            obj.HanaHaba = ReadUInt16(buffer);
            obj.HanaTakasa = ReadUInt16(buffer);
            obj.HanaKakudo = ReadUInt16(buffer);
            obj.KuchiHaba = ReadUInt16(buffer);
            obj.KuchiAtsusa = ReadUInt16(buffer);
            obj.EyebrowUVOffsetX = ReadUInt16(buffer);
            obj.EyebrowUVOffsetY = ReadUInt16(buffer);
            obj.Wrinkle = ReadUInt16(buffer);
            obj.WrinkleAlbedoBlendRate = ReadUInt16(buffer);
            obj.WrinkleDetailNormalPower = ReadUInt16(buffer);
            obj.MuscleAlbedoBlendRate = ReadUInt16(buffer);
            obj.MuscleDetailNormalPower = ReadUInt16(buffer);
            obj.Height = ReadUInt16(buffer);
            obj.HeadSize = ReadUInt16(buffer);
            obj.NeckOffset = ReadUInt16(buffer);
            obj.NeckScale = ReadUInt16(buffer);
            obj.UpperBodyScaleX = ReadUInt16(buffer);
            obj.BellySize = ReadUInt16(buffer);
            obj.TeatScale = ReadUInt16(buffer);
            obj.TekubiSize = ReadUInt16(buffer);
            obj.KoshiOffset = ReadUInt16(buffer);
            obj.KoshiSize = ReadUInt16(buffer);
            obj.AnkleOffset = ReadUInt16(buffer);
            obj.Fat = ReadUInt16(buffer);
            obj.Muscle = ReadUInt16(buffer);
            obj.MotionFilter = ReadUInt16(buffer);
            return obj;
        }
    }
}
