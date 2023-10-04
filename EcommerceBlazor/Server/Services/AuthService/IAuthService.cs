﻿namespace EcommerceBlazor.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Cadastro(Usuario usuario, string senha);
        Task<bool> UsuarioExiste(string email);
        Task<ServiceResponse<string>> Login(string email, string senha);
    }
}