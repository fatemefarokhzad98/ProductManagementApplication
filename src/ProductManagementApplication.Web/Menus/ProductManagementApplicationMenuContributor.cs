using System.Threading.Tasks;
using ProductManagementApplication.Localization;
using ProductManagementApplication.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace ProductManagementApplication.Web.Menus;

public class ProductManagementApplicationMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ProductManagementApplicationResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ProductManagementApplicationMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            ));
        context.Menu.AddItem(
                  new ApplicationMenuItem(
                "ProductManagementApplication",
          l["Menu:ProductManagement"],
               icon: "fas fa-shopping-cart"
                  ).AddItem(
                 new ApplicationMenuItem(
              "ProductManagementApplication.Products",
             l["Menu:Products"],
                url: "/Products")));
        ////context.Menu.Items.Insert(
        ////   0,
        ////   new ApplicationMenuItem(
        ////    "Products",
        ////       l["Menu:Products"],
        ////       "~/Products",
        ////       icon: "fas fa-shopping-cart",
        ////       order: 0
        ////   ));

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
