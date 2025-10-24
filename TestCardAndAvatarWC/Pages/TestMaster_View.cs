using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CardAndAvatarWC.Pages;

namespace TestCardAndAvatarWC
{
  [Collection("CardAndAvatarWC")]
  public class TestMaster_View
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbCardModule),
        typeof(IgbAvatarModule));
      var componentUnderTest = ctx.RenderComponent<Master_View>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
