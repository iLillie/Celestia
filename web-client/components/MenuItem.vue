<template>
  <li class="li-item">
    <a :href="linkItem.href" :target="linkItem.target" >
      <span :class="linkItem.icon"></span>
      <div  :class="{ collapse:  this.$parent.isCollapsed}">
        <p>{{linkItem.text}}</p>
      </div>
    </a>
  </li>
</template>

<script>
export default {
  name: "MenuItem",
  props: {
    linkItem: Object
  }
}
</script>

<style scoped>
  a {
    transition: background-color 300ms ease-in-out;
    @apply flex bg-transparent gap-2.5 p-4 font-sans items-center text-lg font-medium text-gray-600 rounded;
  }

  a:hover {
    @apply bg-gray-200;
  }

  .collapse {
    display: none;
  }


</style>
