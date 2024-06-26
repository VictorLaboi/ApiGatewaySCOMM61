﻿namespace ApiGateway.Gateway.Dtos
{
    public class UsuarioDto
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
