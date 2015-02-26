﻿Shader "UI.Windows/Transitions/Ripple" {

	Properties {
	
		 [HideInInspector] _MainTex("From (RGB)", 2D) = "white" {}
         [HideInInspector] _ClearScreen("ClearScreen (RGB)", 2D) = "white" {}
         _Value("Value", Range(0, 1)) = 0
         
		_Amplitude ( "Amplitude", Float ) = 10.0
		_Speed ( "Speed", Float ) = 5.0
		
	}

	SubShader {
	
		Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }
		Blend SrcAlpha OneMinusSrcAlpha

		Pass {
		
			CGPROGRAM
			#pragma exclude_renderers ps3 xbox360
			#pragma fragmentoption ARB_precision_hint_fastest
			#pragma vertex vert_img
			#pragma fragment frag

			#include "UnityCG.cginc"


			// uniforms
			sampler2D _MainTex;
			sampler2D _ClearScreen;
			uniform fixed _Value;
			uniform float _Amplitude;
			uniform float _Speed;


			fixed4 frag( v2f_img i ) : COLOR {
			
				fixed value = 1 - _Value;
				if (value < 0.5) value = 1 - value;
			
				half2 dir = i.uv - half2( 0.5, 0.5 );
				float dist = length( dir );
				half2 offset = dir * ( sin( _Time.x * dist * _Amplitude * value - value * _Speed) + 0.5 ) / 30.0;

				return lerp( lerp( tex2D( _MainTex, i.uv + offset ), tex2D(_ClearScreen, i.uv + offset), _Value), fixed4( 0.0, 0.0, 0.0, 0.0 ), smoothstep( 0.5, 1.0, value ) );
				
			}

			ENDCG
			
		} // end Pass
		
	} // end SubShader

	FallBack "Diffuse"
}