using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Any;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace APIMaladiesCronique.Tools
{
    public class JwtTool
    {
        private readonly IConfiguration _configuration;
        public JwtTool(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public string GenerateJwtToken(AnyType jsonData, DateTime expiresDate)
        {
            //Convert the jsonData to string
            string jsonDataString = JObject.FromObject(jsonData).ToString();
            // Create claims based on your JSON data
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, jsonDataString),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            // Add more claims as needed
            };

            // Create the security key
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            // Create the signing credentials
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Create the JWT token
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                claims,
                expires: expiresDate, // Set expiration time as needed
                signingCredentials: creds
            );

            // Serialize the JWT token to a string
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}
