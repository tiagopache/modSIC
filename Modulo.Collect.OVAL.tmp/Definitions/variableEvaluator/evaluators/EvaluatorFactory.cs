﻿/*
 * Modulo Open Distributed SCAP Infrastructure Collector (modSIC)
 * 
 * Copyright (c) 2011, Modulo Solutions for GRC.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice,
 *   this list of conditions and the following disclaimer.
 *   
 * - Redistributions in binary form must reproduce the above copyright 
 *   notice, this list of conditions and the following disclaimer in the
 *   documentation and/or other materials provided with the distribution.
 *   
 * - Neither the name of Modulo Security, LLC nor the names of its
 *   contributors may be used to endorse or promote products derived from
 *   this software without specific  prior written permission.
 *   
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modulo.Collect.OVAL.Definitions;
using Modulo.Collect.OVAL.SystemCharacteristics;
using Modulo.Collect.OVAL.Variables;

namespace Modulo.Collect.OVAL.Definitions.VariableEvaluators.Evaluators
{
    public class EvaluatorFactory
    {
        /// <summary>
        /// Creates the correct implementation of variable for the evaluation.
        /// </summary>
        /// <param name="variable">The oval definitions variable.</param>
        /// <returns></returns>
        public Evaluator CreateVariable(VariableType variable, oval_system_characteristics sytemCharacteristics, IEnumerable<VariableType> variablesOfDefinitions, oval_variables externalVariables) 
        {
            if (variable is VariablesTypeVariableConstant_variable)
                return new ConstantVariableEvaluator((VariablesTypeVariableConstant_variable)variable);
            else if (variable is VariablesTypeVariableLocal_variable)
                return new LocalVariableEvaluator((VariablesTypeVariableLocal_variable)variable, sytemCharacteristics, variablesOfDefinitions);
            else if (variable is VariablesTypeVariableExternal_variable)
                return new ExternalVariableEvaluator((VariablesTypeVariableExternal_variable)variable, externalVariables);
           return null;
        }
    }
}
