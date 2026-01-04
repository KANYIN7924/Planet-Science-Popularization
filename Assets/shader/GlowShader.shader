Shader "Custom/GlowShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _GlowColor ("Glow Color", Color) = (1, 1, 1, 1)
        _GlowIntensity ("Glow Intensity", Range(0, 5)) = 1
        _EdgeWidth ("Edge Width", Range(0, 0.1)) = 0.01
    }
 
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100
 
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
 
            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
 
            sampler2D _MainTex;
            float4 _GlowColor;
            float _GlowIntensity;
            float _EdgeWidth;
 
            v2f vert (appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
 
            half4 frag (v2f i) : SV_Target
            {
                half4 texColor = tex2D(_MainTex, i.uv);
                half4 glowColor = _GlowColor * _GlowIntensity;
                half4 edgeGlow = texColor;
                edgeGlow.rgb = lerp(edgeGlow.rgb, glowColor.rgb, smoothstep(1.0 - _EdgeWidth, 1.0, texColor.a));
                return edgeGlow;
            }
            ENDCG
        }
    }
}
