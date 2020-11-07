using System;
using Classes;
using UnityEngine;
using Factories;

namespace Game_Controller_Scripts
{
    public class JsonReader : MonoBehaviour
    {
        public TextAsset jsonFile;
        // Factories
        [SerializeField] private BlindGazerFactory blindGazerFactory;
        [SerializeField] private DrunkSkeletonFactory drunkSkeletonFactory;
        [SerializeField] private AxyFactory axyFactory;
        [SerializeField] private WallFactory wallFactory;
        [SerializeField] private FinishLineFactory finishLineFactory;
        [SerializeField] private RatFactory ratFactory;
        
        void Start()
        {
            JsonInfo jsoNinfo = JsonUtility.FromJson<JsonInfo>(jsonFile.text);
            CreateWalls(jsoNinfo);
            CreateEnemies(jsoNinfo, "BG");
            CreateEnemies(jsoNinfo, "DS");
            CreateEnemies(jsoNinfo, "Rat");
            CreateAxy(jsoNinfo);
            CreateFinishLine(jsoNinfo);
            
        }

        private void CreateWalls(JsonInfo json)
        {
            wallJSON wall = json.walls[0];
            for (int i = 0; i < wall.positions.Count - 1; i += 2)
            {
                var inst = wallFactory.GetNewInstance();
                var transform1 = inst.transform;
                transform1.position = new Vector2(wall.positions[i], wall.positions[i+1]);
                transform1.localScale = new Vector2(wall.scales[i], wall.scales[i+1]);
            }
        }

        private void CreateEnemies(JsonInfo json, String ene)
        {
            if (ene == "BG")
            {
                blindGazersJSON enemy = json.blindGazers[0];
                for (int i = 0; i < enemy.positions.Count - 1; i += 2)
                {
                    var inst = blindGazerFactory.GetNewInstance();
                    inst.transform.position = new Vector2(enemy.positions[i], enemy.positions[i+1]);
                }
            }
            else if (ene == "DS")
            {
                drunkSkeletonJSON enemy = json.drunkSkeletons[0];
                for (int i = 0; i < enemy.positions.Count - 1; i += 2)
                {
                    var inst = drunkSkeletonFactory.GetNewInstance();
                    inst.transform.position = new Vector2(enemy.positions[i], enemy.positions[i+1]);
                }
            }
            else if (ene == "Rat")
            {
                ratJSON rat = json.rats[0];
                for (int i = 0; i < rat.positions.Count - 1; i+= 2)
                {
                    var inst = ratFactory.GetNewInstance();
                    inst.transform.position = new Vector2(rat.positions[i], rat.positions[i+1]);
                }
            }
        }

        private void CreateAxy(JsonInfo json)
        {
            axyJSON _axy = json.axy[0];
            var inst = axyFactory.GetNewInstance();
            var transform1 = inst.transform;
            transform1.position = new Vector2(_axy.position[0], _axy.position[1]);
        }
        
        private void CreateFinishLine(JsonInfo json)
        {
            finishLineJSON _finishLine = json.finishLine[0];
            var inst = finishLineFactory.GetNewInstance();
            var transform1 = inst.transform;
            transform1.position = new Vector2(_finishLine.position[0], _finishLine.position[1]);
        }
    }
}
