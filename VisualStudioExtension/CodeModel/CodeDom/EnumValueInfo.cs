using System;
using EnvDTE80;

namespace Typewriter.CodeModel.CodeDom
{
    public class EnumValueInfo : ItemInfo, IEnumValueInfo
    {
        private readonly CodeVariable2 codeVariable;
        private readonly int index;

        public EnumValueInfo(CodeVariable2 codeVariable, FileInfo file, int index) : base(codeVariable, file)
        {
            this.codeVariable = codeVariable;
            this.index = index;
        }

        public int Value
        {
            get { return codeVariable.InitExpression == null ? index : int.Parse(codeVariable.InitExpression.ToString()); }
        }
    }
}