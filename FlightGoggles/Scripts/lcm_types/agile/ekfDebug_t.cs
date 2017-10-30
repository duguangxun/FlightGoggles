/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace agile
{
    public sealed class ekfDebug_t : LCM.LCM.LCMEncodable
    {
        public long utime;
        public short numFeatures;
        public short numWide;
        public short numPointsAvailable;
        public short numPoints;
        public short numMatched;
        public short numOutliers;
        public double matchingTime;
        public double setupTime;
        public double updateTime;
        public double totalTime;
 
        public ekfDebug_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x6b17fcdf2ff43aceL;
 
        static ekfDebug_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("agile.ekfDebug_t"))
                return 0L;
 
            classes.Add("agile.ekfDebug_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            outs.Write(this.utime); 
 
            outs.Write(this.numFeatures); 
 
            outs.Write(this.numWide); 
 
            outs.Write(this.numPointsAvailable); 
 
            outs.Write(this.numPoints); 
 
            outs.Write(this.numMatched); 
 
            outs.Write(this.numOutliers); 
 
            outs.Write(this.matchingTime); 
 
            outs.Write(this.setupTime); 
 
            outs.Write(this.updateTime); 
 
            outs.Write(this.totalTime); 
 
        }
 
        public ekfDebug_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public ekfDebug_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static agile.ekfDebug_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            agile.ekfDebug_t o = new agile.ekfDebug_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.utime = ins.ReadInt64();
 
            this.numFeatures = ins.ReadInt16();
 
            this.numWide = ins.ReadInt16();
 
            this.numPointsAvailable = ins.ReadInt16();
 
            this.numPoints = ins.ReadInt16();
 
            this.numMatched = ins.ReadInt16();
 
            this.numOutliers = ins.ReadInt16();
 
            this.matchingTime = ins.ReadDouble();
 
            this.setupTime = ins.ReadDouble();
 
            this.updateTime = ins.ReadDouble();
 
            this.totalTime = ins.ReadDouble();
 
        }
 
        public agile.ekfDebug_t Copy()
        {
            agile.ekfDebug_t outobj = new agile.ekfDebug_t();
            outobj.utime = this.utime;
 
            outobj.numFeatures = this.numFeatures;
 
            outobj.numWide = this.numWide;
 
            outobj.numPointsAvailable = this.numPointsAvailable;
 
            outobj.numPoints = this.numPoints;
 
            outobj.numMatched = this.numMatched;
 
            outobj.numOutliers = this.numOutliers;
 
            outobj.matchingTime = this.matchingTime;
 
            outobj.setupTime = this.setupTime;
 
            outobj.updateTime = this.updateTime;
 
            outobj.totalTime = this.totalTime;
 
            return outobj;
        }
    }
}
