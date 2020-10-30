import json

map = {}

map['blindGazers'] = []
map['blindGazers'].append({
    'positions': [0, 0]
})
map["axy"] = []
map['axy'].append({
    'position': [4.5, 0.18]
})

map["drunkSkeletons"] = []
map['drunkSkeletons'].append({
    'positions': [-4.16, 0.04],
})

map["walls"] = []
map["walls"].append({
    "positions": [0.66, 2.9, 0.66, -5.66, -6.7, -1.4, 6.7, -1.4],
    "scales": [14, 0.7, 14, 0.7, 0.7, 9.3, 0.7, 9.3]
})

map["finishLine"] = []
map["finishLine"].append({
    "position": [-4, -2]
})

with open('test1.txt', 'w') as outfile:
    json.dump(map, outfile)
