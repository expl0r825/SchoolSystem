using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Infrastructure.Data.IdentiyModels;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public UserController(
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager,
            RoleManager<ApplicationRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.UserName
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "User");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LoginViewModel();

            model.ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (await roleManager.RoleExistsAsync(roleName) == false)
            {
                var role = new ApplicationRole()
                {
                    Name = roleName
                };

                await roleManager.CreateAsync(role);
            }


            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public async Task<IActionResult> AddUserToRole(string username, string rolename)
        {
            if (await roleManager.RoleExistsAsync(rolename))
            {
                var user = await userManager.FindByNameAsync(username);

                if (user != null)
                {
                    if (await userManager.IsInRoleAsync(user, rolename) == false)
                    {
                        await userManager.AddToRoleAsync(user, rolename);
                    }
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult CheckRole(string rolename)
        {
            return Ok(User.IsInRole(rolename));
        }




        public async Task<IActionResult> AddStudents()
        {
            var borisstefanov = await userManager.FindByIdAsync("0e119a09-9c6b-46c2-bb9b-5151d5b8a8d7");
            var milenageorgieva = await userManager.FindByIdAsync("109824cc-6b9f-4b1f-af65-87bb5a4ff79b");
            var magdalinaivanova = await userManager.FindByIdAsync("10b1bb25-7f3e-4ec5-bb68-9f8282850711");
            var magdalenaivanova = await userManager.FindByIdAsync("1443d844-bfd9-45a1-94a5-83c18f140c0e");
            var bogdankolev = await userManager.FindByIdAsync("15b7349f-c184-42e7-9a18-0c0dd1a05bea");
            var valentinadimitrova = await userManager.FindByIdAsync("162d8979-1a84-4642-9b27-49973518a040");
            var georgimarinov = await userManager.FindByIdAsync("172ef32c-2c8e-49f9-8c0f-0d8236a98fc7");
            var nataliyavasileva = await userManager.FindByIdAsync("17b6757b-33e6-4d97-b8f4-22e3ec4e34a3");
            var radinkaivanova = await userManager.FindByIdAsync("1b441729-6f7d-4d13-9f0b-3fe4e76727c3");
            var kristinapetrova = await userManager.FindByIdAsync("1f49e02f-784c-4b51-856b-0fc301da5bf0");

            IdentityResult result1 = await userManager.AddToRoleAsync(borisstefanov, "Student");
            IdentityResult result2 = await userManager.AddToRoleAsync(milenageorgieva, "Student");
            IdentityResult result3 = await userManager.AddToRoleAsync(magdalinaivanova, "Student");
            IdentityResult result4 = await userManager.AddToRoleAsync(magdalenaivanova, "Student");
            IdentityResult result5 = await userManager.AddToRoleAsync(bogdankolev, "Student");
            IdentityResult result6 = await userManager.AddToRoleAsync(valentinadimitrova, "Student");
            IdentityResult result7 = await userManager.AddToRoleAsync(georgimarinov, "Student");
            IdentityResult result8 = await userManager.AddToRoleAsync(nataliyavasileva, "Student");
            IdentityResult result9 = await userManager.AddToRoleAsync(radinkaivanova, "Student");
            IdentityResult result10 = await userManager.AddToRoleAsync(kristinapetrova, "Student");

            //10

            var dimitarivanov = await userManager.FindByIdAsync("21d56e3d-8c91-431e-a6e2-760848cf2aae");
            var radoslavgeorgiev = await userManager.FindByIdAsync("23dbfde3-00c5-47d9-b1b4-23f97379881e");
            var aneliyakoleva = await userManager.FindByIdAsync("2b765779-8f0d-4d01-b822-41fb42f9d173");
            var darinkakoleva = await userManager.FindByIdAsync("2bd002d3-ff51-4a18-a155-dc76bba5130a");
            var martinkolev = await userManager.FindByIdAsync("2c537f9a-c6ef-43d1-98da-e63d947de2bd");
            var mariyapetrova = await userManager.FindByIdAsync("2e07c9b0-d2a4-41e7-b8d8-0e0384c5e81b");
            var stanimirtodorov = await userManager.FindByIdAsync("31b1f166-5412-40c7-b0cb-38aaec6a5ba6");
            var tsvetanchogeorgiev = await userManager.FindByIdAsync("321efec2-563e-4f66-a158-7c2e4f7db24b");
            var desislavdimitrov = await userManager.FindByIdAsync("3251a6f3-1415-4173-8d95-509d9b57a4bb");
            var radostinaivanova = await userManager.FindByIdAsync("39b55a1b-d8b5-4bb2-9e71-cc994a1463d5");

            IdentityResult res1 = await userManager.AddToRoleAsync(dimitarivanov, "Student");
            IdentityResult res2 = await userManager.AddToRoleAsync(radoslavgeorgiev, "Student");
            IdentityResult res3 = await userManager.AddToRoleAsync(aneliyakoleva, "Student");
            IdentityResult res4 = await userManager.AddToRoleAsync(darinkakoleva, "Student");
            IdentityResult res5 = await userManager.AddToRoleAsync(martinkolev, "Student");
            IdentityResult res6 = await userManager.AddToRoleAsync(mariyapetrova, "Student");
            IdentityResult res7 = await userManager.AddToRoleAsync(stanimirtodorov, "Student");
            IdentityResult res8 = await userManager.AddToRoleAsync(tsvetanchogeorgiev, "Student");
            IdentityResult res9 = await userManager.AddToRoleAsync(desislavdimitrov, "Student");
            IdentityResult res10 = await userManager.AddToRoleAsync(radostinaivanova, "Student");

            //20

            var gerganadimitrova = await userManager.FindByIdAsync("3f13969e-28fc-4315-b44d-b0f7b827202a");
            var ivostoyanov = await userManager.FindByIdAsync("41c16c1c-6345-487b-9202-18bf7a723b5e");
            var krasimirdimitrov = await userManager.FindByIdAsync("5038ef42-267f-4a5d-8b92-2d63052265c8");
            var sonyaivanova = await userManager.FindByIdAsync("512da3a0-4861-49ac-9142-1536f5ea2cb1");
            var vasilaleksandrov = await userManager.FindByIdAsync("57ef3794-e725-4d7c-9d17-7b7ac01081c5");
            var elenakoleva = await userManager.FindByIdAsync("5a141fd9-2bcf-4dab-8c0a-8c15b7c8dbef");
            var nikolaykolev = await userManager.FindByIdAsync("5a7d1e4a-8f4f-4e52-9d14-06f9d3a134b4");
            var yavorivanov = await userManager.FindByIdAsync("5b38fb70-63e4-4d02-a14f-3b58ff14bc76");
            var elenastoyanova = await userManager.FindByIdAsync("61f620da-d214-4e17-852a-c96fddcc682a");
            var ventsislavpetrov = await userManager.FindByIdAsync("675b60ea-ee3f-4e58-b8d4-109b9ab54d99");

            IdentityResult resu1 = await userManager.AddToRoleAsync(gerganadimitrova, "Student");
            IdentityResult resu2 = await userManager.AddToRoleAsync(ivostoyanov, "Student");
            IdentityResult resu3 = await userManager.AddToRoleAsync(krasimirdimitrov, "Student");
            IdentityResult resu4 = await userManager.AddToRoleAsync(sonyaivanova, "Student");
            IdentityResult resu5 = await userManager.AddToRoleAsync(vasilaleksandrov, "Student");
            IdentityResult resu6 = await userManager.AddToRoleAsync(elenakoleva, "Student");
            IdentityResult resu7 = await userManager.AddToRoleAsync(nikolaykolev, "Student");
            IdentityResult resu8 = await userManager.AddToRoleAsync(yavorivanov, "Student");
            IdentityResult resu9 = await userManager.AddToRoleAsync(elenastoyanova, "Student");
            IdentityResult resu10 = await userManager.AddToRoleAsync(ventsislavpetrov, "Student");

            //30

            var kalinchopetrov = await userManager.FindByIdAsync("6a4e15d5-29ae-4b86-9015-21d61e22e947");
            var vasilenkaivanova = await userManager.FindByIdAsync("6a56e5a9-b77d-492e-82c5-eab5c9397756");
            var ivankolev = await userManager.FindByIdAsync("6c704485-8f35-4b5d-aa5b-c971b87cb442");
            var nadezhdaivanova = await userManager.FindByIdAsync("71c4c53d-0c7e-4d33-b8b3-15b3ff206249");
            var neligeorgieva = await userManager.FindByIdAsync("731e88f2-bb26-46d8-8d53-031af77b5e15");
            var kalinadimitrova = await userManager.FindByIdAsync("7b1a2e32-bc36-4bf7-9b65-07fbfa810baa");
            var petarpetrov = await userManager.FindByIdAsync("7d2f14fb-b3b5-4598-8989-ba10d3612c96");
            var teodoravasileva = await userManager.FindByIdAsync("7fbd8c2e-38c6-4a97-aa74-6321ee1f0e2a");
            var viktoriaivanova = await userManager.FindByIdAsync("7fc4b81c-0b22-4e35-bc17-c7c3e73d1874");
            var militsapetrova = await userManager.FindByIdAsync("80a73e8d-3a08-44b3-ba99-8a5ea3ebd012");

            IdentityResult resul1 = await userManager.AddToRoleAsync(kalinchopetrov, "Student");
            IdentityResult resul2 = await userManager.AddToRoleAsync(vasilenkaivanova, "Student");
            IdentityResult resul3 = await userManager.AddToRoleAsync(ivankolev, "Student");
            IdentityResult resul4 = await userManager.AddToRoleAsync(nadezhdaivanova, "Student");
            IdentityResult resul5 = await userManager.AddToRoleAsync(neligeorgieva, "Student");
            IdentityResult resul6 = await userManager.AddToRoleAsync(kalinadimitrova, "Student");
            IdentityResult resul7 = await userManager.AddToRoleAsync(petarpetrov, "Student");
            IdentityResult resul8 = await userManager.AddToRoleAsync(teodoravasileva, "Student");
            IdentityResult resul9 = await userManager.AddToRoleAsync(viktoriaivanova, "Student");
            IdentityResult resul10 = await userManager.AddToRoleAsync(militsapetrova, "Student");

            //40

            var yordangeorgiev = await userManager.FindByIdAsync("80f4cb68-199a-4f6d-8b82-6ad3521c0b52");
            var zdravkokolev = await userManager.FindByIdAsync("844dd2c8-e20b-4423-827f-349e0bbd2761");
            var asengeorgiev = await userManager.FindByIdAsync("84ab245c-804d-4ac7-8f9e-bcda15863c5c");
            var lyubomiratodorova = await userManager.FindByIdAsync("8a4b8f2d-72e8-46d1-8a9f-2d06b1d9ecf1");
            var kameliyatodorova = await userManager.FindByIdAsync("8b7f9c67-7985-4f3f-a2a1-271189e22a0d");
            var aleksandartodorov = await userManager.FindByIdAsync("8c0cb95d-0e1a-40c4-9e2f-2542d530dbaa");
            var vanyakoleva = await userManager.FindByIdAsync("8d0a37e9-91a1-4b3a-86a9-b57595b104ab");
            var kirildimitrov = await userManager.FindByIdAsync("8d9f8a3f-16a2-4fe5-b12a-32c3f3c66fb1");
            var danielamarinova = await userManager.FindByIdAsync("8f35f8dd-b52a-4084-818b-3e1813e42f19");
            var mariavasileva = await userManager.FindByIdAsync("93a6ac3b-c8c9-4a24-a00b-4f54e2f4d2d7");

            IdentityResult re1 = await userManager.AddToRoleAsync(yordangeorgiev, "Student");
            IdentityResult re2 = await userManager.AddToRoleAsync(zdravkokolev, "Student");
            IdentityResult re3 = await userManager.AddToRoleAsync(asengeorgiev, "Student");
            IdentityResult re4 = await userManager.AddToRoleAsync(lyubomiratodorova, "Student");
            IdentityResult re5 = await userManager.AddToRoleAsync(kameliyatodorova, "Student");
            IdentityResult re6 = await userManager.AddToRoleAsync(aleksandartodorov, "Student");
            IdentityResult re7 = await userManager.AddToRoleAsync(vanyakoleva, "Student");
            IdentityResult re8 = await userManager.AddToRoleAsync(kirildimitrov, "Student");
            IdentityResult re9 = await userManager.AddToRoleAsync(danielamarinova, "Student");
            IdentityResult re10 = await userManager.AddToRoleAsync(mariavasileva, "Student");

            //50

            var iliyapetrov = await userManager.FindByIdAsync("961b318b-7e65-4ef9-bf8e-3e22f74cdd6d");
            var bozhidardimitrov = await userManager.FindByIdAsync("98fb09c1-54d0-4d9c-86ee-7f7b510695ef");
            var lyubomirgeorgiev = await userManager.FindByIdAsync("9c1e0838-6a1b-4158-92a2-36c6234e9d41");
            var silviyaivanova = await userManager.FindByIdAsync("9e32eab9-84e3-4b35-bb92-89b3dfb8e98f");
            var stefaniyapetrova = await userManager.FindByIdAsync("a3bd2a1d-5061-439e-aec9-0e54720e3ed5");
            var galyaivanova = await userManager.FindByIdAsync("b2f18679-974f-4648-891b-05df89900b85");
            var emiliageorgieva = await userManager.FindByIdAsync("b4c1c7da-6491-48d6-91d5-3c4f43105fc1");
            var simeongeorgiev = await userManager.FindByIdAsync("b5245ba7-c0e2-4e7d-b144-e9b7d8889e6e");
            var emiltodorov = await userManager.FindByIdAsync("b7395fbb-59e7-4687-9b69-0f135abf8e72");
            var gabrielastoyanova = await userManager.FindByIdAsync("c618a246-9af9-4a37-9e0d-257ec4b2b854");

            IdentityResult e1 = await userManager.AddToRoleAsync(iliyapetrov, "Student");
            IdentityResult e2 = await userManager.AddToRoleAsync(bozhidardimitrov, "Student");
            IdentityResult e3 = await userManager.AddToRoleAsync(lyubomirgeorgiev, "Student");
            IdentityResult e4 = await userManager.AddToRoleAsync(silviyaivanova, "Student");
            IdentityResult e5 = await userManager.AddToRoleAsync(stefaniyapetrova, "Student");
            IdentityResult e6 = await userManager.AddToRoleAsync(galyaivanova, "Student");
            IdentityResult e7 = await userManager.AddToRoleAsync(emiliageorgieva, "Student");
            IdentityResult e8 = await userManager.AddToRoleAsync(simeongeorgiev, "Student");
            IdentityResult e9 = await userManager.AddToRoleAsync(emiltodorov, "Student");
            IdentityResult e10 = await userManager.AddToRoleAsync(gabrielastoyanova, "Student");

            //60

            var stefchodimitrov = await userManager.FindByIdAsync("c6aa9e1c-1894-4ef8-9a29-29c110f31949");
            var ralitsadimitrova = await userManager.FindByIdAsync("cff038d2-716a-4c45-8f21-81b1e7769a74");
            var ivaylopetrov = await userManager.FindByIdAsync("d071556f-89ee-4819-86b2-7eb3b63f65a2");
            var hristopetrov = await userManager.FindByIdAsync("d0b3c3d4-5803-4f42-9f3f-5879926e2f3f");
            var plamenivanov = await userManager.FindByIdAsync("d1983bf8-cb42-4da2-88d2-5297be88a146");
            var elenapetrova = await userManager.FindByIdAsync("d3d28ff2-79fe-4e7a-bf85-8e4fe2e0a097");
            var kamenchopetrov = await userManager.FindByIdAsync("d68684c7-c3a8-4c21-8042-b76a4f43ff33");
            var rositsageorgieva = await userManager.FindByIdAsync("d6ddbe61-7627-4b88-bc3c-8c2b3a7e89a4");
            var dilyanaivanova = await userManager.FindByIdAsync("d8b46962-25a4-4977-8363-d43e7076c85f");
            var rosenpetrov = await userManager.FindByIdAsync("e20a8a8b-7038-45c5-b292-91c7b5e196d1");

            IdentityResult r1 = await userManager.AddToRoleAsync(stefchodimitrov, "Student");
            IdentityResult r2 = await userManager.AddToRoleAsync(ralitsadimitrova, "Student");
            IdentityResult r3 = await userManager.AddToRoleAsync(ivaylopetrov, "Student");
            IdentityResult r4 = await userManager.AddToRoleAsync(hristopetrov, "Student");
            IdentityResult r5 = await userManager.AddToRoleAsync(plamenivanov, "Student");
            IdentityResult r6 = await userManager.AddToRoleAsync(elenapetrova, "Student");
            IdentityResult r7 = await userManager.AddToRoleAsync(kamenchopetrov, "Student");
            IdentityResult r8 = await userManager.AddToRoleAsync(rositsageorgieva, "Student");
            IdentityResult r9 = await userManager.AddToRoleAsync(dilyanaivanova, "Student");
            IdentityResult r10 = await userManager.AddToRoleAsync(rosenpetrov, "Student");

            //70

            var hristiyanivanov = await userManager.FindByIdAsync("e2b8904e-9a9e-471d-af7b-ef17f62f0e35");
            var tanyageorgieva = await userManager.FindByIdAsync("f0578b4d-49cc-4c3c-8b61-62ebc8c196e9");
            var rumchoivanov = await userManager.FindByIdAsync("f3dd26e0-e2eb-4e1f-9ea2-d260e779a5e3");
            var antonivanov = await userManager.FindByIdAsync("f4ec527a-d87f-4e87-b948-26e7d4c3351f");

            IdentityResult rer1 = await userManager.AddToRoleAsync(hristiyanivanov, "Student");
            IdentityResult rer2 = await userManager.AddToRoleAsync(tanyageorgieva, "Student");
            IdentityResult rer3 = await userManager.AddToRoleAsync(rumchoivanov, "Student");
            IdentityResult rer4 = await userManager.AddToRoleAsync(antonivanov, "Student");



            return RedirectToAction("Index", "Home");
        }
    }
}
