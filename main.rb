a = 'soundararajan'
b = 'dhakshinamoorthy'
dict = {}
a.each_char {|ch|
  if dict[ch] == nil then
    dict[ch]= 1
  else
    dict[ch]=dict[ch]+ 1
  end
}

print "Repeating : "
b.each_char {|ch|
  if dict[ch]== nil then
    dict[ch]= -1
  else
    print ch
    dict[ch] = dict[ch]- 1
  end
}

puts ""

print "Only in first :"
for ch in dict.keys do
  count  = dict[ch]
  if count > 0 then
    count.times do
      print ch
    end
  end
end

puts ""
print "Only in second :"
STDOUT.flush
for ch in dict.keys do
  count = dict[ch]
  if count < 0 then
    (-count).times do
      print ch
    end
  end
end
