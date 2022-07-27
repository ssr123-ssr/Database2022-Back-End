using ExpressSystem.Models;
using ExpressSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressSystem.Controllers
{
    public class AccountController : Controller
    {
        //定义在登录界面的几种状态
        const int loginInit = 0;
        const int registerSuccess = 1;
        const int loginFail = 2;
        const int registerFail = 3;
        const int registerWarn = 4;

        private readonly IUserRepository _userRepository;
        //public AccountViewModel _accountViewModel = new AccountViewModel();

        public AccountController(IUserRepository userRepository)
        {
            //依赖注入
            _userRepository = userRepository;
        }


        public IActionResult Index()
        {
            IEnumerable<User> users = _userRepository.GerAllUsers();
            return View(users);            
        }


        #region  登录             
        [HttpGet]
        public IActionResult Login(int status)
        {
            AccountViewModel accountViewModel = new AccountViewModel()
            {
                registerStatus=status
            };

            return View(accountViewModel);
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            User cur_user = _userRepository.GetUser(user.ID);

            //如果该用户存在
            if (cur_user != null)
            {
                if (user.PASSWORD == cur_user.PASSWORD)
                {
                    return RedirectToAction("privacy","home");   //这里应该返回登录的角色的界面

                    //if (cur_user.ROLE == "用户")
                    //    return View("Client", new { id = cur_user.ID });
                    //else if (cur_user.ROLE == "快递员")
                    //    return View("Courier", new { id = cur_user.ID });
                    //else if (cur_user.ROLE == "司机")
                    //    return View("Transportation", new { id = cur_user.ID });
                    //else if (cur_user.ROLE == "代收点")
                    //    return View("Poststation", new { id = cur_user.ID });
                    //else if (cur_user.ROLE == "转运中心")
                    //    return View("Distribution_Center", new { id = cur_user.ID });
                    //else if (cur_user.ROLE == "快递公司")
                    //    return View("Express_Company", new { id = cur_user.ID });
                }
            }

            //用户名或密码错误  提示  返回
            AccountViewModel accountViewModel = new AccountViewModel()
            {
                registerStatus = loginFail
            };
       
            return View(accountViewModel);
        }

        #endregion


        #region  注册
        [HttpGet]
        public IActionResult Register(int status)
        {
            AccountViewModel accountViewModel = new AccountViewModel()
            {
                registerStatus = status
            };

            return View(accountViewModel);
        }


        [HttpPost]
        public IActionResult Register(User user)
        {
            AccountViewModel accountViewModel = new AccountViewModel();

            if (ModelState.IsValid)
            {
                //判断是否已经存在该用户
                //如果不存在 注册
                if (_userRepository.GetUser(user.ID) == null)
                {
                    Regex regex1 = new Regex(@"^[0-9]{7}$");
                    Regex regex2 = new Regex(@"^[0-9]{5}$");

                    if (user.ROLE == "0")
                    {
                        if (!regex1.IsMatch(user.ID))
                        {
                            accountViewModel.registerStatus = registerWarn;

                            //创建成功返回登录界面
                            return View(accountViewModel);
                        }
                    }
                    else
                    {
                        if (!regex2.IsMatch(user.ID))
                        {
                            accountViewModel.registerStatus = registerWarn;

                            //创建成功返回登录界面
                            return View(accountViewModel);
                        }
                    }


                    //判断并为角色赋值
                    switch (user.ROLE)
                    {
                        case "0":
                            user.ROLE = "用户";
                            break;
                        case "1":
                            user.ROLE = "快递员";
                            break;
                        case "2":
                            user.ROLE = "司机";
                            break;
                        case "3":
                            user.ROLE = "代收点";
                            break;
                        case "4":
                            user.ROLE = "转运中心";
                            break;
                        case "5":
                            user.ROLE = "快递公司";
                            break;
                    }

                   
                    _userRepository.Add(user);   //将新建用户信息添加仓储中

                    accountViewModel.registerStatus = registerSuccess;
                    
                    //创建成功返回登录界面
                    return View("Login", accountViewModel);
                }
                else
                {
                    //如果已经存在  
                    //用户名或密码错误  提示  返回
                    accountViewModel.registerStatus = registerFail;

                    return View(accountViewModel);
                }
            }

            accountViewModel.registerStatus = loginInit;

            return View(accountViewModel);
        }

        #endregion
    }
}
