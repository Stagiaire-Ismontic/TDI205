declare @cmp int=0
while @cmp<5
begin
if(@cmp=1)
print 'Hello'
if(@cmp=2)
print 'world'
else
print 'Nothing'
set @cmp=@cmp+1;
end