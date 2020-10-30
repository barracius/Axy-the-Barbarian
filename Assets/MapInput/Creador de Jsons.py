import json

map = {}

map['blindGazers'] = []
map['blindGazers'].append({
    'positions': [(0, 0)],
    'movementSpeeds': 5
})
map["axy"] = []
map['axy'].append({
    'position': (4.5, 0.18),
})

map["drunkSkeletons"] = []
map['drunkSkeletons'].append({
    'positions': [(-4.16, 0.04)],
})

map["horizontalWalls"] = []
map["horizontalWalls"].append({
    "positions": [(0.66, 2.9), (0.66, -5.66)],
    "scales": [(14, 0.7), (14, 0.7)],
})

map["verticalWalls"] = []
map["verticalWalls"].append({
    "positions": [(-6.7, -1.4), (6.7, -1.4), ()],
    "scales": [(0.7, 9.3), (0.7, 9.3)],
})

map["finishLine"] = []
map["finishLine"].append({
    "position": (-4, -2)
})

with open('data.txt', 'w') as outfile:
    json.dump(map, outfile)
