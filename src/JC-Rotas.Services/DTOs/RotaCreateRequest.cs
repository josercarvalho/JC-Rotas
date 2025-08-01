﻿using System.ComponentModel.DataAnnotations;

namespace JC_Rotas.Services.DTOs;

public class RotaCreateRequest
{
    [Required(ErrorMessage = "A origem é obrigatória")]
    [StringLength(3, MinimumLength = 3, ErrorMessage = "A origem deve ter exatamente 3 caracteres")]
    public string Origem { get; set; }

    [Required(ErrorMessage = "O destino é obrigatório")]
    [StringLength(3, MinimumLength = 3, ErrorMessage = "O destino deve ter exatamente 3 caracteres")]
    public string Destino { get; set; }

    [Required(ErrorMessage = "O valor é obrigatório")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero")]
    public decimal Valor { get; set; }
}
