using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurmanProject.Components {
    internal class AnswerRadio:RadioButton {
        /// <summary>
        /// This object holds answer object of the radio button
        /// </summary>
        public tb_answers answer;
        /// <summary>
        /// Constructor of AnswerRadio
        /// </summary>
        /// <param name="_answer"></param>
        public AnswerRadio(tb_answers _answer) {
            answer = _answer;
        }
    }
}
