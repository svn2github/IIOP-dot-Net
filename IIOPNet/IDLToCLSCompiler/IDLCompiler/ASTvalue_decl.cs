/* Generated By:JJTree: Do not edit this line. ASTvalue_decl.cs */

using System;

namespace parser {

    public class ASTvalue_decl : SimpleNode {
                
        #region IConstructors

        public ASTvalue_decl(int id) : base(id) {
        }

        public ASTvalue_decl(IDLParser p, int id) : base(p, id) {
        }
        
        #endregion IConstructors
        #region IMethods


        /** Accept the visitor. **/
        public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
            return visitor.visit(this, data);
        }
  
        public override string GetIdentification() {
            return "value " + ((SimpleNode)jjtGetChild(0)).GetIdentification() + "(in " + 
                   ((SimpleNode)jjtGetParent()).GetEmbedderDesc() + ")";
        }    
  
        public override string GetEmbedderDesc() {
            return ((SimpleNodeWithIdent)jjtGetChild(0)).getIdent() + 
                   " (in " + ((SimpleNode)jjtGetParent()).GetEmbedderDesc() + ")";
        }
        
        #endregion IMethods
  
    }

}

