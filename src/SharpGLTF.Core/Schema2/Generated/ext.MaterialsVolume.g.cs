// <auto-generated/>

//------------------------------------------------------------------------------------------------
//      This file has been programatically generated; DON´T EDIT!
//------------------------------------------------------------------------------------------------

#pragma warning disable SA1001
#pragma warning disable SA1027
#pragma warning disable SA1028
#pragma warning disable SA1121
#pragma warning disable SA1205
#pragma warning disable SA1309
#pragma warning disable SA1402
#pragma warning disable SA1505
#pragma warning disable SA1507
#pragma warning disable SA1508
#pragma warning disable SA1652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.Json;

namespace SharpGLTF.Schema2
{
	using Collections;

	/// <summary>
	/// glTF extension that defines the parameters for the volume of a material.
	/// </summary>
	partial class MaterialVolume : ExtraProperties
	{
	
		private static readonly Vector3 _attenuationColorDefault = Vector3.One;
		private Vector3? _attenuationColor = _attenuationColorDefault;
		
		private const Double _attenuationDistanceExclusiveMinimum = 0;
		private Double? _attenuationDistance;
		
		private const Double _thicknessFactorDefault = 0;
		private const Double _thicknessFactorMinimum = 0;
		private Double? _thicknessFactor = _thicknessFactorDefault;
		
		private TextureInfo _thicknessTexture;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "attenuationColor", _attenuationColor, _attenuationColorDefault);
			SerializeProperty(writer, "attenuationDistance", _attenuationDistance);
			SerializeProperty(writer, "thicknessFactor", _thicknessFactor, _thicknessFactorDefault);
			SerializePropertyObject(writer, "thicknessTexture", _thicknessTexture);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "attenuationColor": _attenuationColor = DeserializePropertyValue<Vector3?>(ref reader); break;
				case "attenuationDistance": _attenuationDistance = DeserializePropertyValue<Double?>(ref reader); break;
				case "thicknessFactor": _thicknessFactor = DeserializePropertyValue<Double?>(ref reader); break;
				case "thicknessTexture": _thicknessTexture = DeserializePropertyValue<TextureInfo>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

}
