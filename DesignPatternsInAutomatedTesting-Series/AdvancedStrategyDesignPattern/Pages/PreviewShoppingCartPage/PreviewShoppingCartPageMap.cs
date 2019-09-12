﻿// <copyright file="PreviewShoppingCartPageMap.cs" company="Automate The Planet Ltd.">
// Copyright 2019 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

using OpenQA.Selenium;

namespace AdvancedStrategyDesignPattern.Pages.PreviewShoppingCartPage
{
    public class PreviewShoppingCartPageMap : Core.BasePageElementMap
    {
        public IWebElement ProceedToCheckoutButton
        {
            get
            {
                return Browser.FindElement(By.Id("hlb-ptc-btn-native"));
            }
        }

        public IWebElement EditYourCartButton
        {
            get
            {
                return Browser.FindElement(By.Id("a-autoid-0-announce"));
            }
        }

        public IWebElement ThisOrderContainsGiftCheckbox
        {
            get
            {
                return Browser.FindElement(By.Id("sc-buy-box-gift-checkbox"));
            }
        }
    }
}