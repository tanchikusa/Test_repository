﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navistar.Tests
{
    public abstract class BaseTest
    {
        protected readonly IWebDriver driver = new ChromeDriver();
    }
}
