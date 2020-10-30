import json

map = {}

map['blindGazers'] = []
map['blindGazers'].append({
    'positions': [-25.41819, -5.202298, -22.95931, -5.202298, -20.13614, -5.293367, -2.286478, 4.633261, 2.540221, 4.8154, 22.66031, -4.912082]
})
map["axy"] = []
map['axy'].append({
    'position': [25.30838, -7.479907]
})

map["drunkSkeletons"] = []
map['drunkSkeletons'].append({
    'positions': [-5.773964, 7.41, -4.836431, -0.2845076, -0.1918712, -0.1934381, 4.543758, -0.1023684, 6.355449, 7.336652, 20.25298, -4.029393],
})

map["walls"] = []
map["walls"].append({
    "positions": [-27, -5, -22.7, -10, -18.38, -6.02, -17.808, 0, 0.047, -2.07, -8.114944, 4.268982, 0.217, 9.28, 8.732966, 4.724329, 18.06, 0, 18.38, -6, 22.7, -10, 27, -5],
    "scales": [0.7, 9.3, 9.3, 0.7, 0.7, 7.3, 19.10306, 0.7, 37.4936, 0.7, 0.7, 9.3, 17.37665, 0.7, 0.7, 9.3, 19.10306, 0.7, 0.7, 7.3, 9.3, 0.7, 0.7, 9.3]
})

map["finishLine"] = []
map["finishLine"].append({
    "position": [-25.32712, -8.29867]
})

with open('test2.txt', 'w') as outfile:
    json.dump(map, outfile)
