using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Model
{
    [SerializeField]
    public class Player
    {
        [SerializeField]
        public string name;

        [SerializeField]
        public string ethereumAddress;

        [SerializeField]
        public int highScore;
    }
}