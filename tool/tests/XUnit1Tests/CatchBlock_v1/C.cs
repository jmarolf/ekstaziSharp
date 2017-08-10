﻿// Copyright (c) 2017, Marko Vasic
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace CatchBlock
{
    public class C
    {
        public int M()
        {
            try
            {
                int dividor = 0;
                return 5 / dividor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                return 2;
            }
        }
    }
}