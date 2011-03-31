Given /^I am on google$/ do
  visit('http://www.google.com/webhp?complete=0&hl=en')
end

When /^I go to google$/ do
  Given "I am on google"
end

When /^I search for "([^"]*)"$/ do |search_query|
  fill_in('q', :with => search_query)
  click_button('Google Search')
end

Then /^I should see "([^"]*)" in the results$/ do |content|
  page.should have_content(content)
end

Then /^I should see the following results:$/ do |table|
  table.hashes.each do |row|
    matches = all('a.l').select do |a|
      a['href'] == row[:link] && a.text.include?(row[:text])
    end
    matches.count.should > 0
  end
end
