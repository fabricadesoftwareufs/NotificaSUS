﻿using Model;
using Persistence;
using Repository.Interfaces;
using System.Linq;

namespace Repository
{
    public class NotificacoesRepository : INotificacoesRepository
    {
        private readonly monitorasusContext _context;
        public NotificacoesRepository(monitorasusContext context)
        {
            _context = context;
        }

        public ConfiguracaoNotificarModel BuscarConfiguracaoNotificar(int IdEstado, int IdEmpresaExame)
            => _context
                    .Configuracaonotificar
                    .Where(c => c.IdEstado == IdEstado && c.IdEmpresaExame == IdEmpresaExame)
                    .Select(conf => new ConfiguracaoNotificarModel
                    {
                        HabilitadoSms = conf.HabilitadoSms,
                        HabilitadoWhatsapp = conf.HabilitadoWhatsapp,
                        IdConfiguracaoNotificar = conf.IdConfiguracaoNotificar,
                        IdEmpresaExame = conf.IdEmpresaExame,
                        IdEstado = conf.IdEstado,
                        IdMunicipio = conf.IdMunicipio,
                        MensagemCurado = conf.MensagemImunizado,
                        MensagemIndeterminado = conf.MensagemIndeterminado,
                        MensagemPositivo = conf.MensagemPositivo,
                        MensagemNegativo = conf.MensagemNegativo,
                        QuantidadeSmsdisponivel = conf.QuantidadeSmsdisponivel,
                        Sid = conf.Sid,
                        Token = conf.Token
                    }).FirstOrDefault();

        public ConfiguracaoNotificarModel BuscarConfiguracaoNotificar(int IdMunicipio)
            => _context
                    .Configuracaonotificar
                    .Where(c => c.IdMunicipio == IdMunicipio)
                    .Select(conf => new ConfiguracaoNotificarModel
                    {
                        HabilitadoSms = conf.HabilitadoSms,
                        HabilitadoWhatsapp = conf.HabilitadoWhatsapp,
                        IdConfiguracaoNotificar = conf.IdConfiguracaoNotificar,
                        IdEmpresaExame = conf.IdEmpresaExame,
                        IdEstado = conf.IdEstado,
                        IdMunicipio = conf.IdMunicipio,
                        MensagemCurado = conf.MensagemImunizado,
                        MensagemIndeterminado = conf.MensagemIndeterminado,
                        MensagemPositivo = conf.MensagemPositivo,
                        MensagemNegativo = conf.MensagemNegativo,
                        QuantidadeSmsdisponivel = conf.QuantidadeSmsdisponivel,
                        Sid = conf.Sid,
                        Token = conf.Token
                    }).FirstOrDefault();
    }
}
