# Hotelapp3
(1-NF)
1- har ett värde i varje tabel av mitt program
2- varje rad är unik och ligger längst ner av programet och unik kolumn
3- varje kolumn har ett värde i
4-varje tabel har PK
5-PK är inte Null, unik, går inte att ändra på id och den skapas varje gång record skapas
(2-NF)
1-mina tabeler uppfyller 1-NF
2-inga partial dependencies
3-Guest_id och Room-ID är primary key och är unik i varje rad.

(3-NF)
1- tabellen uppfyller 1-NF och 2-NF
2- det finns inte transitive functional dependencies som kan påverka andra tabeller när vi försöker göra någon ändring i en annan kolumn.
