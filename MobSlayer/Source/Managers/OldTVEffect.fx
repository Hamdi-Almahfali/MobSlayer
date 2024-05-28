sampler2D TextureSampler : register(s0);

float screenHeight;
float lineThickness = 1.0f; // Thickness of the black lines

float4 MainPS(float4 color : COLOR0, float2 texCoord : TEXCOORD0) : COLOR
{
    float yCoord = texCoord.y * screenHeight;
    if (fmod(yCoord, lineThickness * 2.0f) < lineThickness)
    {
        // Add a black line
        return float4(0, 0, 0, 1);
    }
    else
    {
        // Display the original color
        return tex2D(TextureSampler, texCoord) * color;
    }
}

technique Technique1
{
    pass Pass1
    {
        PixelShader = compile ps_4_0 MainPS();
    }
}