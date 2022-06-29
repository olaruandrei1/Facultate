# Breadth First Search

import numpy as np
import os
import time

class Node:
    def __init__(self, node_no, data, parent, act, cost):
        self.data = data  # puzzle-ul
        self.parent = parent  # Nodul parinte
        self.act = act  # Actiunea pentru creerea nodului
        self.node_no = node_no  # id nod
        self.cost = cost  # Costul


def get_initial():
    print("Introduceti numere de la 0 la 8")
    # Initializez un array 
    initial_state = np.zeros(9)
    for i in range(9):
        states = int(input(
            "Introduceti un numar pentru pozitia: " + str(i + 1) + " Numarul ales: "))  # Citirea respectiv completarea puzzle-ului
        if states < 0 or states > 8:   # Conditia ca cifrele completate sa fie cumprinse in intervalul 1-8, respectiv 0(spatiul gol) 
            print("Nu ati introdus numere in intervalul [0,8]!")
            exit(0)
        else:
            initial_state[i] = np.array(states)  # Atribuim numarul
    return np.reshape(initial_state, (3, 3))   # Returnam starea initiala ca pe o matrice in format 3x3


def find_index(puzzle):
    # Aflarea pozitiei lui "0", pentru a putea verifica unde se poate muta
    i, j = np.where(puzzle == 0)
    i = int(i)
    j = int(j)
    return i, j


def move_left(data):
    i, j = find_index(data)
    if j == 0:
        return None
    else:
        temp_arr = np.copy(data)  # Copierea array-ului
        temp = temp_arr[i, j - 1] # Miscarea
        # Initiez interschimbarea
        temp_arr[i, j] = temp
        temp_arr[i, j - 1] = 0
        return temp_arr


def move_right(data):
    i, j = find_index(data)
    if j == 2:
        return None
    else:
        temp_arr = np.copy(data) # Copierea array-ului
        temp = temp_arr[i, j + 1] # Miscarea
        # Initiez interschimbarea
        temp_arr[i, j] = temp
        temp_arr[i, j + 1] = 0
        return temp_arr


def move_up(data):
    i, j = find_index(data)
    if i == 0:
        return None
    else:
        temp_arr = np.copy(data) # Copierea array-ului
        temp = temp_arr[i - 1, j] # Miscarea
        # Initiez interschimbarea
        temp_arr[i, j] = temp
        temp_arr[i - 1, j] = 0
        return temp_arr


def move_down(data):
    i, j = find_index(data)
    if i == 2:
        return None
    else:
        temp_arr = np.copy(data) # Copierea array-ului
        temp = temp_arr[i + 1, j] # Miscarea
        # Initiez interschimbarea
        temp_arr[i, j] = temp
        temp_arr[i + 1, j] = 0
        return temp_arr


def move_tile(action, data):
    # Verificarea miscarii necesare
    if action == 'up':
        return move_up(data)
    if action == 'down':
        return move_down(data)
    if action == 'left':
        return move_left(data)
    if action == 'right':
        return move_right(data)
    else:
        return None


def print_states(list_final): # Print pentru Starea Finala
    print("Solutia finala")
    for l in list_final:
        print("Move : " + str(l.act) + "\n" + "Result : " + "\n" + str(l.data) + "\t" + "node number:" + str(l.node_no))


def write_path(path_formed): # Print in Notepad pentru path-ul final
    if os.path.exists("Path_file.txt"):
        os.remove("Path_file.txt")

    f = open("Path_file.txt", "a")
    for node in path_formed:
        if node.parent is not None:
            f.write(str(node.node_no) + "\t" + str(node.parent.node_no) + "\t" + str(node.cost) + "\n")
    f.close()


def write_node_explored(explored):  # Printarea in Notepad pentru toate nodurile explorate de algoritm
    if os.path.exists("Node.txt"):
        os.remove("Node.txt")

    f = open("Node.txt", "a")
    for element in explored:
        f.write('[')
        for i in range(len(element)):
            for j in range(len(element)):
                f.write(str(element[j][i]) + " ")
        f.write(']')
        f.write("\n")
    f.close()


def write_node_info(visited):   # Printarea in Notepad pentru informatiile despre toate nodurile parcurse
    if os.path.exists("Node_info.txt"):
        os.remove("Node_info.txt")

    f = open("Node_info.txt", "a")
    for n in visited:
        if n.parent is not None:
            f.write(str(n.node_no) + "\t" + str(n.parent.node_no) + "\t" + str(n.cost) + "\n")
    f.close()


# Gasirea path-ului initial, de la cel final
def path(node):
    print(node)
    p = []  # Empty list
    p.append(node)
    parent_node = node.parent
    while parent_node is not None:
        p.append(parent_node)
        parent_node = parent_node.parent
    return list(reversed(p))


def exploring_nodes(node, goal_node):
    time0 = time.time()
    print("Exploram nodurile")
    actions = ["down", "up", "left", "right"]
    node_q = [node]
    final_nodes = []
    visited = []
    final_nodes.append(node_q[0].data.tolist())  #Scrierea puzzle-urilor din nodurile vizitatea
    node_counter = 0  # Id

    while node_q:

        current_root = node_q.pop(0) # Scoatem cu .pop elementul "0" din lista # starea SC
        # Daca este starea finala
        if current_root.data.tolist() == goal_node.tolist():  # Daca SC este stare finala
            time1 = time.time()
            print("Starea finala a fost gasita! A durat: " + str(time1 - time0))
            return current_root, final_nodes, visited

        for move in actions:
            temp_data = move_tile(move, current_root.data)  # Miscarile posibile
            if temp_data is not None: # Daca se poate face o mutare:
                node_counter += 1
                child_node = Node(node_counter, np.array(temp_data), current_root, move, 0)  # Initierea nodului copil

                if child_node.data.tolist() not in final_nodes: # Adaugarea nodului copil in lista nodului final
                    node_q.append(child_node)
                    final_nodes.append(child_node.data.tolist())
                    visited.append(child_node)
                    # Daca nodul copil creeat este starea finala:
                    if child_node.data.tolist() == goal_node.tolist():
                        time1 = time.time()
                        print("Starea finala a fost gasita! A durat: " + str(time1 - time0))
                        return child_node, final_nodes, visited
    return None, None, None  # Daca nodul final nu a fost gasit


def check_correct_input(l):
    # Verificam daca in completarea puzzle-ului sunt numere introduse de mai multe ori
    array = np.reshape(l, 9)
    for i in range(9):
        counter_appear = 0
        f = array[i]
        for j in range(9):
            if f == array[j]:
                counter_appear += 1
        if counter_appear >= 2:
            print("invalid input, same number entered 2 times")
            exit(0)


# Back-up, in caz de sunt sunt bug-uri la def get_intial sau termninal
# k = np.array([[1, 2, 3], [4, 5, 6], [7, 8, 0]])


print('Starea initiala')
# starea initiala
k = get_initial()
print('Starea finala')
# starea finala
x = get_initial()

#Verificarea intergritatii inputului
check_correct_input(k)
check_correct_input(x)

# Initializarea primul nod
#(numar nod, starea initiala, parinte, actiune/directie, cost)
root = Node(0, k, None, None, 0)

# Apelare BFS 
goal, s, v = exploring_nodes(root, x)
# Unde s = final node, v = visited


print_states(path(goal))
write_path(path(goal))
write_node_explored(s)
write_node_info(v)
