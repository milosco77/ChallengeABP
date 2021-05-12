﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ChallengeABP.Alumnado.Localization;
using Volo.Abp.Account.Localization;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace ChallengeABP.Alumnado.Blazor.Menus
{
    public class AlumnadoMenuContributor : IMenuContributor
    {
        private readonly IConfiguration _configuration;

        public AlumnadoMenuContributor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
            else if (context.Menu.Name == StandardMenus.User)
            {
                await ConfigureUserMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<AlumnadoResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    AlumnadoMenus.Home,
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

                        context.Menu.AddItem(
                new ApplicationMenuItem(
                    "StudentList",
                    l["Menu:StudentList"],
                    icon: "fa fa-graduation-cap"
                ).AddItem(
                new ApplicationMenuItem(
                    "Students",
                    l["Menu:Students"],
                    url: "/alumnos"
                    )
                )
            );


            return Task.CompletedTask;
        }

        private Task ConfigureUserMenuAsync(MenuConfigurationContext context)
        {
            var accountStringLocalizer = context.GetLocalizer<AccountResource>();
            var currentUser = context.ServiceProvider.GetRequiredService<ICurrentUser>();

            var identityServerUrl = _configuration["AuthServer:Authority"] ?? "";

            if (currentUser.IsAuthenticated)
            {
                context.Menu.AddItem(new ApplicationMenuItem(
                    "Account.Manage",
                    accountStringLocalizer["ManageYourProfile"],
                    $"{identityServerUrl.EnsureEndsWith('/')}Account/Manage?returnUrl={_configuration["App:SelfUrl"]}",
                    icon: "fa fa-cog",
                    order: 1000,
                    null));
            }

            return Task.CompletedTask;
        }
    }
}
